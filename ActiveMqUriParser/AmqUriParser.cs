using System;

// Ignore Spelling: amq

namespace Skyware.ActiveMq;

public class AmqUriParser : GenericUriParser
{
    public AmqUriParser(GenericUriParserOptions options) : base(options)
    {
    }

    // TODO: See https://www.codeproject.com/Articles/13773/Writing-a-custom-UriParser-for-NET

    // ActiveMQ Docs: https://activemq.apache.org/components/classic/documentation/connection-configuration-uri 
}

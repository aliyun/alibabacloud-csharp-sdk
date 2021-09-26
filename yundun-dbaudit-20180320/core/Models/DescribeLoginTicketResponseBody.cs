// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_dbaudit20180320.Models
{
    public class DescribeLoginTicketResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("LoginTicket")]
        [Validation(Required=false)]
        public DescribeLoginTicketResponseBodyLoginTicket LoginTicket { get; set; }
        public class DescribeLoginTicketResponseBodyLoginTicket : TeaModel {
            [NameInMap("Ticket")]
            [Validation(Required=false)]
            public string Ticket { get; set; }
            [NameInMap("Certificate")]
            [Validation(Required=false)]
            public string Certificate { get; set; }
            [NameInMap("Zones")]
            [Validation(Required=false)]
            public List<DescribeLoginTicketResponseBodyLoginTicketZones> Zones { get; set; }
            public class DescribeLoginTicketResponseBodyLoginTicketZones : TeaModel {
                public string ZoneId { get; set; }
                public string LocalName { get; set; }
            }
        };

    }

}

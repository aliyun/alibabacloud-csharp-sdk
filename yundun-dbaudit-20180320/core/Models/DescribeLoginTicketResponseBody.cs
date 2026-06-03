// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_dbaudit20180320.Models
{
    public class DescribeLoginTicketResponseBody : TeaModel {
        [NameInMap("LoginTicket")]
        [Validation(Required=false)]
        public DescribeLoginTicketResponseBodyLoginTicket LoginTicket { get; set; }
        public class DescribeLoginTicketResponseBodyLoginTicket : TeaModel {
            [NameInMap("Certificate")]
            [Validation(Required=false)]
            public string Certificate { get; set; }

            [NameInMap("Ticket")]
            [Validation(Required=false)]
            public string Ticket { get; set; }

            [NameInMap("Zones")]
            [Validation(Required=false)]
            public List<DescribeLoginTicketResponseBodyLoginTicketZones> Zones { get; set; }
            public class DescribeLoginTicketResponseBodyLoginTicketZones : TeaModel {
                [NameInMap("LocalName")]
                [Validation(Required=false)]
                public string LocalName { get; set; }

                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

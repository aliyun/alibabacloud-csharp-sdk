// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class RemoveTerminalsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>16A96B9A-F203-4EC5-8E43-CB92E68F4CD8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Terminals")]
        [Validation(Required=false)]
        public RemoveTerminalsResponseBodyTerminals Terminals { get; set; }
        public class RemoveTerminalsResponseBodyTerminals : TeaModel {
            [NameInMap("Terminal")]
            [Validation(Required=false)]
            public List<RemoveTerminalsResponseBodyTerminalsTerminal> Terminal { get; set; }
            public class RemoveTerminalsResponseBodyTerminalsTerminal : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public int? Code { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1811****</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Success</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

            }

        }

    }

}

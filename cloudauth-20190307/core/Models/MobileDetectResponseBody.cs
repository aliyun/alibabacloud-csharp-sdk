// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class MobileDetectResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>969434DF-926B-4997-9881-4DE94E39F805</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultObject")]
        [Validation(Required=false)]
        public MobileDetectResponseBodyResultObject ResultObject { get; set; }
        public class MobileDetectResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ChargeCount")]
            [Validation(Required=false)]
            public string ChargeCount { get; set; }

            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<MobileDetectResponseBodyResultObjectItems> Items { get; set; }
            public class MobileDetectResponseBodyResultObjectItems : TeaModel {
                [NameInMap("Area")]
                [Validation(Required=false)]
                public string Area { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("BizCode")]
                [Validation(Required=false)]
                public string BizCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CMCC</para>
                /// </summary>
                [NameInMap("IspName")]
                [Validation(Required=false)]
                public string IspName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>131********</para>
                /// </summary>
                [NameInMap("Mobile")]
                [Validation(Required=false)]
                public string Mobile { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>101</para>
                /// </summary>
                [NameInMap("SubCode")]
                [Validation(Required=false)]
                public string SubCode { get; set; }

            }

        }

    }

}

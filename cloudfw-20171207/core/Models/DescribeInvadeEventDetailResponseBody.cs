// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeInvadeEventDetailResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>i-8vb2nmm070m****</para>
        /// </summary>
        [NameInMap("AssetsInstanceId")]
        [Validation(Required=false)]
        public string AssetsInstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ECS_test</para>
        /// </summary>
        [NameInMap("AssetsInstanceName")]
        [Validation(Required=false)]
        public string AssetsInstanceName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("EventDesc")]
        [Validation(Required=false)]
        public string EventDesc { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("EventDetail")]
        [Validation(Required=false)]
        public string EventDetail { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>C&amp;CActivity</para>
        /// </summary>
        [NameInMap("EventKey")]
        [Validation(Required=false)]
        public string EventKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>event_test</para>
        /// </summary>
        [NameInMap("EventName")]
        [Validation(Required=false)]
        public string EventName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>aa6e786c-5034-457a-8e05-1c63fab****</para>
        /// </summary>
        [NameInMap("EventUuid")]
        [Validation(Required=false)]
        public string EventUuid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1735006706</para>
        /// </summary>
        [NameInMap("FirstTime")]
        [Validation(Required=false)]
        public int? FirstTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsIgnore")]
        [Validation(Required=false)]
        public bool? IsIgnore { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1740104108</para>
        /// </summary>
        [NameInMap("LastTime")]
        [Validation(Required=false)]
        public int? LastTime { get; set; }

        [NameInMap("OperationList")]
        [Validation(Required=false)]
        public List<DescribeInvadeEventDetailResponseBodyOperationList> OperationList { get; set; }
        public class DescribeInvadeEventDetailResponseBodyOperationList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Args")]
            [Validation(Required=false)]
            public string Args { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>RunMode</para>
            /// </summary>
            [NameInMap("Operate")]
            [Validation(Required=false)]
            public string Operate { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10.21.186.XXX</para>
        /// </summary>
        [NameInMap("PrivateIP")]
        [Validation(Required=false)]
        public string PrivateIP { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ProcessStatus")]
        [Validation(Required=false)]
        public int? ProcessStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>106.15.185.XXX</para>
        /// </summary>
        [NameInMap("PublicIP")]
        [Validation(Required=false)]
        public string PublicIP { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Reference")]
        [Validation(Required=false)]
        public string Reference { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionNo")]
        [Validation(Required=false)]
        public string RegionNo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8022D695-4A35-50BC-8697-EA9C233A****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("RiskLevel")]
        [Validation(Required=false)]
        public int? RiskLevel { get; set; }

        [NameInMap("UnhandleOperationList")]
        [Validation(Required=false)]
        public List<DescribeInvadeEventDetailResponseBodyUnhandleOperationList> UnhandleOperationList { get; set; }
        public class DescribeInvadeEventDetailResponseBodyUnhandleOperationList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Args")]
            [Validation(Required=false)]
            public string Args { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>RunMode</para>
            /// </summary>
            [NameInMap("Operate")]
            [Validation(Required=false)]
            public string Operate { get; set; }

        }

    }

}

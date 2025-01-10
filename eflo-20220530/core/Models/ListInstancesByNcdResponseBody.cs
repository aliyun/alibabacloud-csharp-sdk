// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo20220530.Models
{
    public class ListInstancesByNcdResponseBody : TeaModel {
        /// <summary>
        /// <para>The response status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The response parameters.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public ListInstancesByNcdResponseBodyContent Content { get; set; }
        public class ListInstancesByNcdResponseBodyContent : TeaModel {
            /// <summary>
            /// <para>A collection of instances whose network communication distance from the source instance ID does not exceed maxNcd</para>
            /// </summary>
            [NameInMap("InstanceInfos")]
            [Validation(Required=false)]
            public List<ListInstancesByNcdResponseBodyContentInstanceInfos> InstanceInfos { get; set; }
            public class ListInstancesByNcdResponseBodyContentInstanceInfos : TeaModel {
                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>lni-1235****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>network communication distance</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Ncd")]
                [Validation(Required=false)]
                public int? Ncd { get; set; }

            }

            /// <summary>
            /// <para>Instance Type</para>
            /// <para>Valid value:</para>
            /// <list type="bullet">
            /// <item><description>node: Lingjun node.</description></item>
            /// <item><description>lni: lingjun network interface controller.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>lni</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>Maximum communication distance between nodes</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("MaxNcd")]
            [Validation(Required=false)]
            public int? MaxNcd { get; set; }

            /// <summary>
            /// <para>The ID of the source instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lni-1234****</para>
            /// </summary>
            [NameInMap("SourceInstanceId")]
            [Validation(Required=false)]
            public string SourceInstanceId { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>You don\&quot;t have the permission of this operation, action=eflo:ListInstancesByNcd, arn=acs:eflo:cn-heyuan:1263399219805497:networkinterface/*, resourceGroup=null</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID of the current request</para>
        /// 
        /// <b>Example:</b>
        /// <para>AC8C713A-A9F4-5984-A5E1-76496DF35153</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

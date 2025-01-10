// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo20220530.Models
{
    public class QueryInstanceNcdResponseBody : TeaModel {
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
        public QueryInstanceNcdResponseBodyContent Content { get; set; }
        public class QueryInstanceNcdResponseBodyContent : TeaModel {
            /// <summary>
            /// <para>Instance 1ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>lni-1235****</para>
            /// </summary>
            [NameInMap("InstanceId1")]
            [Validation(Required=false)]
            public string InstanceId1 { get; set; }

            /// <summary>
            /// <para>Instance 2ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>lni-1234****</para>
            /// </summary>
            [NameInMap("InstanceId2")]
            [Validation(Required=false)]
            public string InstanceId2 { get; set; }

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
            /// <para>network communication distance between instances</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Ncd")]
            [Validation(Required=false)]
            public int? Ncd { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>You don\&quot;t have the permission of this operation, action=eflo:QueryInstanceNcd, arn=acs:eflo:cn-shenzhen:1263399219805497:networkinterface/*, resourceGroup=null</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID of the current request</para>
        /// 
        /// <b>Example:</b>
        /// <para>BDBCC783-84CA-5733-8EEA-645C88B9009C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

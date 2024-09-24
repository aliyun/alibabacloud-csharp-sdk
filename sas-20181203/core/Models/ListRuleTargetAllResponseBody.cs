// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListRuleTargetAllResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30CBF632-109F-596F-97F2-451C8B2A****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>An array that consists of the network objects.</para>
        /// </summary>
        [NameInMap("RuleTargetList")]
        [Validation(Required=false)]
        public List<ListRuleTargetAllResponseBodyRuleTargetList> RuleTargetList { get; set; }
        public class ListRuleTargetAllResponseBodyRuleTargetList : TeaModel {
            /// <summary>
            /// <para>The ID of the network object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>301944</para>
            /// </summary>
            [NameInMap("TargetId")]
            [Validation(Required=false)]
            public long? TargetId { get; set; }

            /// <summary>
            /// <para>The name of the network object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>source-test-obj-xFKcx</para>
            /// </summary>
            [NameInMap("TargetName")]
            [Validation(Required=false)]
            public string TargetName { get; set; }

            /// <summary>
            /// <para>The type of the object. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>IMAGE</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>IMAGE</para>
            /// </summary>
            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

        }

    }

}

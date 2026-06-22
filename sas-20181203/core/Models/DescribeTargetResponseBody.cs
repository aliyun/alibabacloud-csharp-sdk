// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeTargetResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>79CFF74D-E967-5407-8A78-EE03B925FDAA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The machine settings for the vulnerability type.</para>
        /// </summary>
        [NameInMap("Targets")]
        [Validation(Required=false)]
        public List<DescribeTargetResponseBodyTargets> Targets { get; set; }
        public class DescribeTargetResponseBodyTargets : TeaModel {
            /// <summary>
            /// <para>The flag. This parameter can be empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>del</para>
            /// </summary>
            [NameInMap("Flag")]
            [Validation(Required=false)]
            public string Flag { get; set; }

            /// <summary>
            /// <para>The target. The value is a machine UUID or a machine group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5c5f0169-3527-40a2-b5ff-0bc1db8f****</para>
            /// </summary>
            [NameInMap("Target")]
            [Validation(Required=false)]
            public string Target { get; set; }

            /// <summary>
            /// <para>The target type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>uuid</b>: added by individual asset</description></item>
            /// <item><description><b>groupId</b>: added by server group.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>uuid</para>
            /// </summary>
            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

        }

        /// <summary>
        /// <para>The total number of machine configuration entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

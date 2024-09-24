// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeTargetResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>79CFF74D-E967-5407-8A78-EE03B925FDAA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the server.</para>
        /// </summary>
        [NameInMap("Targets")]
        [Validation(Required=false)]
        public List<DescribeTargetResponseBodyTargets> Targets { get; set; }
        public class DescribeTargetResponseBodyTargets : TeaModel {
            /// <summary>
            /// <para>The flag that is added to the server. This parameter can be empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>del</para>
            /// </summary>
            [NameInMap("Flag")]
            [Validation(Required=false)]
            public string Flag { get; set; }

            /// <summary>
            /// <para>The UUID of the server or the ID of the server group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5c5f0169-3527-40a2-b5ff-0bc1db8f****</para>
            /// </summary>
            [NameInMap("Target")]
            [Validation(Required=false)]
            public string Target { get; set; }

            /// <summary>
            /// <para>The type of the object. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>uuid</b>: a server</description></item>
            /// <item><description><b>groupId</b>: a server group</description></item>
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
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class ModifyHybridMonitorSLSGroupRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The configurations of the Logstore group.</para>
        /// <para>Valid values of N: 1 to 25.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SLSGroupConfig")]
        [Validation(Required=false)]
        public List<ModifyHybridMonitorSLSGroupRequestSLSGroupConfig> SLSGroupConfig { get; set; }
        public class ModifyHybridMonitorSLSGroupRequestSLSGroupConfig : TeaModel {
            /// <summary>
            /// <para>The Logstore.</para>
            /// <para>Valid values of N: 1 to 25.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Logstore-aliyun-all</para>
            /// </summary>
            [NameInMap("SLSLogstore")]
            [Validation(Required=false)]
            public string SLSLogstore { get; set; }

            /// <summary>
            /// <para>The Simple Log Service project.</para>
            /// <para>Valid values of N: 1 to 25.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aliyun-project</para>
            /// </summary>
            [NameInMap("SLSProject")]
            [Validation(Required=false)]
            public string SLSProject { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// <para>Valid values of N: 1 to 25.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("SLSRegion")]
            [Validation(Required=false)]
            public string SLSRegion { get; set; }

            /// <summary>
            /// <para>The member ID.</para>
            /// <para>Valid values of N: 1 to 25.</para>
            /// <para>If you call this operation by using the management account of a resource directory, you can connect the Alibaba Cloud services that are activated for all members in the resource directory to Hybrid Cloud Monitoring. You can use the resource directory to monitor Alibaba Cloud services across enterprise accounts.</para>
            /// <remarks>
            /// <para>If a member uses CloudMonitor for the first time, you must make sure that the service-linked role AliyunServiceRoleForCloudMonitor is attached to the member. For more information, see <a href="https://help.aliyun.com/document_detail/170423.html">Manage the service-linked role for CloudMonitor</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>120886317861****</para>
            /// </summary>
            [NameInMap("SLSUserId")]
            [Validation(Required=false)]
            public string SLSUserId { get; set; }

        }

        /// <summary>
        /// <para>The description of the Logstore group.</para>
        /// </summary>
        [NameInMap("SLSGroupDescription")]
        [Validation(Required=false)]
        public string SLSGroupDescription { get; set; }

        /// <summary>
        /// <para>The name of the Logstore group.</para>
        /// <para>For information about how to obtain the name of a Logstore group, see <a href="https://help.aliyun.com/document_detail/429526.html">DescribeHybridMonitorSLSGroup</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Logstore_test</para>
        /// </summary>
        [NameInMap("SLSGroupName")]
        [Validation(Required=false)]
        public string SLSGroupName { get; set; }

    }

}

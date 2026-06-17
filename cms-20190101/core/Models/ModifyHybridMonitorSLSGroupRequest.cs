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
            /// <para>The log project.</para>
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
            /// <para>The region.</para>
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
            /// <para>When you invoke this operation by using a management account, you can associate the Alibaba Cloud services of any member in the resource folder with Hybrid Cloud Monitoring through cloud native mode. You can use the resource folder to monitor the Alibaba Cloud services of multiple accounts.</para>
            /// <remarks>
            /// <para>If a member uses CloudMonitor for the first time, make sure that the member has completed authorization for the CloudMonitor service-linked role (AliyunServiceRoleForCloudMonitor). For more information, see <a href="https://help.aliyun.com/document_detail/170423.html">CloudMonitor service-linked role</a>.</para>
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
        /// 
        /// <b>Example:</b>
        /// <para>Logstore group of Alibaba Cloud products.</para>
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

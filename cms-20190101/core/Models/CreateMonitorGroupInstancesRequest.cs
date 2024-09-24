// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class CreateMonitorGroupInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3607****</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The instances that you want to add to the application group.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<CreateMonitorGroupInstancesRequestInstances> Instances { get; set; }
        public class CreateMonitorGroupInstancesRequestInstances : TeaModel {
            /// <summary>
            /// <para>The abbreviation of the Alibaba Cloud service name.</para>
            /// <para>To obtain the abbreviation of an Alibaba Cloud service name, call the <a href="https://help.aliyun.com/document_detail/114916.html">DescribeProjectMeta</a> operation. The <c>metricCategory</c> tag in the <c>Labels</c> response parameter indicates the abbreviation of the Alibaba Cloud service name.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-2ze26xj5wwy12****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The instance name.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-instance-ecs</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The region ID of the instance.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}

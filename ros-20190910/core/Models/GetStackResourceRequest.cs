// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetStackResourceRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to query the resource properties. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The name of resource property N that you want to query.</para>
        /// <remarks>
        /// <para> Maximum value of N: 20.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WebServer</para>
        /// </summary>
        [NameInMap("LogicalResourceId")]
        [Validation(Required=false)]
        public string LogicalResourceId { get; set; }

        /// <summary>
        /// <para>The logical ID of the resource defined in the template.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The status of the resource. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CREATE_COMPLETE</description></item>
        /// <item><description>CREATE_FAILED</description></item>
        /// <item><description>CREATE_IN_PROGRESS</description></item>
        /// <item><description>UPDATE_IN_PROGRESS</description></item>
        /// <item><description>UPDATE_FAILED</description></item>
        /// <item><description>UPDATE_COMPLETE</description></item>
        /// <item><description>DELETE_IN_PROGRESS</description></item>
        /// <item><description>DELETE_FAILED</description></item>
        /// <item><description>CHECK_IN_PROGRESS</description></item>
        /// <item><description>CHECK_FAILED</description></item>
        /// <item><description>CHECK_COMPLETE</description></item>
        /// <item><description>IMPORT_IN_PROGRESS</description></item>
        /// <item><description>IMPORT_FAILED</description></item>
        /// <item><description>IMPORT_COMPLETE</description></item>
        /// </list>
        /// </summary>
        [NameInMap("ResourceAttributes")]
        [Validation(Required=false)]
        public List<string> ResourceAttributes { get; set; }

        /// <summary>
        /// <para>The name of resource property N that you want to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ShowResourceAttributes")]
        [Validation(Required=false)]
        public bool? ShowResourceAttributes { get; set; }

        /// <summary>
        /// <para>The ID of the region to which the stack belongs. You can call the <a href="https://help.aliyun.com/document_detail/131035.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4a6c9851-3b0f-4f5f-b4ca-a14bf691****</para>
        /// </summary>
        [NameInMap("StackId")]
        [Validation(Required=false)]
        public string StackId { get; set; }

    }

}

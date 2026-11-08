// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class CreateMonitorGroupByResourceGroupIdRequest : TeaModel {
        /// <summary>
        /// <para>The alert contact group. Alert notifications for the application group are sent to the alert contacts in this alert contact group.</para>
        /// <para>An alert contact group is a collection of alert contacts and can contain one or more alert contacts. For more information about how to create alert contacts and alert contact groups, see <a href="https://help.aliyun.com/document_detail/114923.html">PutContact</a> and <a href="https://help.aliyun.com/document_detail/114929.html">PutContactGroup</a>. For more information about how to obtain alert contact groups, see <a href="https://help.aliyun.com/document_detail/114922.html">DescribeContactGroupList</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECS_Group</para>
        /// </summary>
        [NameInMap("ContactGroupList")]
        [Validation(Required=false)]
        public List<string> ContactGroupList { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable automatic installation of the CloudMonitor agent for the application group. CloudMonitor automatically installs the CloudMonitor agent on hosts in the application group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Enabled.</para>
        /// </description></item>
        /// <item><description><para>false: Disabled. Default value.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableInstallAgent")]
        [Validation(Required=false)]
        public bool? EnableInstallAgent { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable automatic subscription to event notifications for the application group. When critical or warning events occur on resources in the application group, CloudMonitor sends alert notifications. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Enabled.</para>
        /// </description></item>
        /// <item><description><para>false: Disabled. Default value.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableSubscribeEvent")]
        [Validation(Required=false)]
        public bool? EnableSubscribeEvent { get; set; }

        /// <summary>
        /// <para>The region ID of the resource group.</para>
        /// <para>For more information about how to obtain the region ID of a resource group, see <a href="https://help.aliyun.com/document_detail/158866.html">GetResourceGroup</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// <para>For more information about how to obtain the resource group ID, see <a href="https://help.aliyun.com/document_detail/158855.html">ListResourceGroups</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmw3ty5y7****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The name of the resource group.</para>
        /// <para>For more information about how to obtain the resource group name, see <a href="https://help.aliyun.com/document_detail/158855.html">ListResourceGroups</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CloudMonitor</para>
        /// </summary>
        [NameInMap("ResourceGroupName")]
        [Validation(Required=false)]
        public string ResourceGroupName { get; set; }

    }

}

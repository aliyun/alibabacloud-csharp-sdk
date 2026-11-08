// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class CreateDynamicTagGroupRequest : TeaModel {
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The alert contact groups. Valid values of N: 1 to 100. Alert notifications for the application group are sent to the alert contacts in the alert contact groups.</para>
        /// <para>An alert contact group contains one or more alert contacts. For more information about how to create alert contacts and alert contact groups, see <a href="https://help.aliyun.com/document_detail/114923.html">PutContact</a> and <a href="https://help.aliyun.com/document_detail/114929.html">PutContactGroup</a>. For more information about how to query alert contact groups, see <a href="https://help.aliyun.com/document_detail/114922.html">DescribeContactGroupList</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECS_Group</para>
        /// </summary>
        [NameInMap("ContactGroupList")]
        [Validation(Required=false)]
        public List<string> ContactGroupList { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform only a dry run on the request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: performs a dry run without creating the queue. The system checks whether required parameters are specified, the request format is valid, and business limits are met. If the request fails the dry run, an error message is returned. If the request passes the dry run, the error code DryRunOperation is returned.</description></item>
        /// <item><description><b>false</b>: performs a dry run and creates the queue if the request passes the dry run. This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable automatic installation of the CloudMonitor agent for the application group. CloudMonitor automatically installs the CloudMonitor agent on the hosts in the application group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: enables automatic installation.</para>
        /// </description></item>
        /// <item><description><para>false: disables automatic installation. This is the default value.</para>
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
        /// <para>Specifies whether to enable automatic subscription to event notifications for the application group. When a critical or warning event occurs on a resource in the application group, CloudMonitor sends an alert notification. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: enables automatic subscription.</para>
        /// </description></item>
        /// <item><description><para>false: disables automatic subscription. This is the default value.</para>
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
        /// <para>The match expression used to generate the application group based on tags.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("MatchExpress")]
        [Validation(Required=false)]
        public List<CreateDynamicTagGroupRequestMatchExpress> MatchExpress { get; set; }
        public class CreateDynamicTagGroupRequestMatchExpress : TeaModel {
            /// <summary>
            /// <para>The tag key used to create the group. If multiple resources contain this key, the matched resources are added to the same group based on the same key-value pair according to the filter conditions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>appname</para>
            /// </summary>
            [NameInMap("TagName")]
            [Validation(Required=false)]
            public string TagName { get; set; }

            /// <summary>
            /// <para>The resource tag value. Valid values of N: 1.</para>
            /// <remarks>
            /// <para>You must specify both MatchExpress.N.TagValueMatchFunction and MatchExpress.N.TagValue at the same time.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>instance</para>
            /// </summary>
            [NameInMap("TagValue")]
            [Validation(Required=false)]
            public string TagValue { get; set; }

            /// <summary>
            /// <para>The matching method for the resource tag value. Valid values of N: 1. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>contains: includes</description></item>
            /// <item><description>startWith: prefix</description></item>
            /// <item><description>endWith: suffix</description></item>
            /// <item><description>notContains: excludes</description></item>
            /// <item><description>equals: equals</description></item>
            /// <item><description>all: all</description></item>
            /// </list>
            /// <remarks>
            /// <para>You must specify both MatchExpress.N.TagValueMatchFunction and MatchExpress.N.TagValue at the same time.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>contains</para>
            /// </summary>
            [NameInMap("TagValueMatchFunction")]
            [Validation(Required=false)]
            public string TagValueMatchFunction { get; set; }

        }

        /// <summary>
        /// <para>The relationship between the conditional expressions of the resource tag values. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>and: AND. This is the default value.</description></item>
        /// <item><description>or: OR.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>and</para>
        /// </summary>
        [NameInMap("MatchExpressFilterRelation")]
        [Validation(Required=false)]
        public string MatchExpressFilterRelation { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The tag key of the resource.</para>
        /// <para>For more information about how to query the tag keys of resources, see <a href="https://help.aliyun.com/document_detail/145558.html">DescribeTagKeyList</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs_instance</para>
        /// </summary>
        [NameInMap("TagKey")]
        [Validation(Required=false)]
        public string TagKey { get; set; }

        /// <summary>
        /// <para>The region ID to which the tag belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("TagRegionId")]
        [Validation(Required=false)]
        public string TagRegionId { get; set; }

        /// <summary>
        /// <para>The IDs of the alert templates.</para>
        /// <para>For more information about how to query the IDs of alert templates, see <a href="https://help.aliyun.com/document_detail/114982.html">DescribeMetricRuleTemplateList</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>85****</para>
        /// </summary>
        [NameInMap("TemplateIdList")]
        [Validation(Required=false)]
        public List<string> TemplateIdList { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class CreateDynamicTagGroupRequest : TeaModel {
        /// <summary>
        /// <para>The alert contact groups. The value of N can be from 1 to 100. Alert notifications for the application group are sent to the alert contacts in these alert contact groups.</para>
        /// <para>An alert contact group can contain one or more alert contacts. For more information about how to create alert contacts and alert contact groups, see <a href="https://help.aliyun.com/document_detail/114923.html">PutContact</a> and <a href="https://help.aliyun.com/document_detail/114929.html">PutContactGroup</a>. For more information about how to obtain alert contact groups, see <a href="https://help.aliyun.com/document_detail/114922.html">DescribeContactGroupList</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECS_Group</para>
        /// </summary>
        [NameInMap("ContactGroupList")]
        [Validation(Required=false)]
        public List<string> ContactGroupList { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically install the CloudMonitor agent for the application group. CloudMonitor automatically installs the agent on the hosts in the application group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: enabled.</para>
        /// </description></item>
        /// <item><description><para>false (default): disabled.</para>
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
        /// <para>Specifies whether to automatically subscribe to event notifications for the application group. When a critical or warning event occurs on a resource in the application group, CloudMonitor sends an alert notification. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: enabled.</para>
        /// </description></item>
        /// <item><description><para>false (default): disabled.</para>
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
        /// <para>The match expressions that are used to create an application group from tags.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("MatchExpress")]
        [Validation(Required=false)]
        public List<CreateDynamicTagGroupRequestMatchExpress> MatchExpress { get; set; }
        public class CreateDynamicTagGroupRequestMatchExpress : TeaModel {
            /// <summary>
            /// <para>The key of the tag that is used to create the group. If multiple resources have this tag key, the resources that meet the filter conditions are added to the same group based on the same key-value pair.</para>
            /// 
            /// <b>Example:</b>
            /// <para>appname</para>
            /// </summary>
            [NameInMap("TagName")]
            [Validation(Required=false)]
            public string TagName { get; set; }

            /// <summary>
            /// <para>The value of the resource tag. The value of N is 1.</para>
            /// <remarks>
            /// <para>You must specify both the <c>MatchExpress.N.TagValueMatchFunction</c> and <c>MatchExpress.N.TagValue</c> parameters.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>instance</para>
            /// </summary>
            [NameInMap("TagValue")]
            [Validation(Required=false)]
            public string TagValue { get; set; }

            /// <summary>
            /// <para>The method that is used to match the values of resource tags. The value of N is 1. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>contains: includes.</para>
            /// </description></item>
            /// <item><description><para>startWith: prefix.</para>
            /// </description></item>
            /// <item><description><para>endWith: suffix.</para>
            /// </description></item>
            /// <item><description><para>notContains: does not include.</para>
            /// </description></item>
            /// <item><description><para>equals: equals.</para>
            /// </description></item>
            /// <item><description><para>all: all.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>You must specify both the <c>MatchExpress.N.TagValueMatchFunction</c> and <c>MatchExpress.N.TagValue</c> parameters.</para>
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
        /// <para>The relationship between the conditional expressions for the tag values. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>and (default)</para>
        /// </description></item>
        /// <item><description><para>or</para>
        /// </description></item>
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
        /// <para>The ID of the region to which the tag belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("TagRegionId")]
        [Validation(Required=false)]
        public string TagRegionId { get; set; }

        /// <summary>
        /// <para>The ID of the alert template.</para>
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

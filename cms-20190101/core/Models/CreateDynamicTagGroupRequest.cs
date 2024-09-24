// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class CreateDynamicTagGroupRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECS_Group</para>
        /// </summary>
        [NameInMap("ContactGroupList")]
        [Validation(Required=false)]
        public List<string> ContactGroupList { get; set; }

        /// <summary>
        /// <para>Specifies whether the CloudMonitor agent is automatically installed for the application group. CloudMonitor determines whether to automatically install the CloudMonitor agent for the hosts in an application group based on the value of this parameter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The CloudMonitor agent is automatically installed.</description></item>
        /// <item><description>false (default value): The CloudMonitor agent is not automatically installed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableInstallAgent")]
        [Validation(Required=false)]
        public bool? EnableInstallAgent { get; set; }

        /// <summary>
        /// <para>Specifies whether the application group automatically subscribes to event notifications. If events whose severity level is critical or warning occur on resources in an application group, CloudMonitor sends alert notifications. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The application group automatically subscribes to event notifications.</description></item>
        /// <item><description>false (default value): The application group does not automatically subscribe to event notifications.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableSubscribeEvent")]
        [Validation(Required=false)]
        public bool? EnableSubscribeEvent { get; set; }

        /// <summary>
        /// <para>The conditional expressions used to create an application group based on the tag.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("MatchExpress")]
        [Validation(Required=false)]
        public List<CreateDynamicTagGroupRequestMatchExpress> MatchExpress { get; set; }
        public class CreateDynamicTagGroupRequestMatchExpress : TeaModel {
            /// <summary>
            /// <para>The keys of the tags that are used to create the application group. If a specified key is attached to multiple resources, the resources that have the same key-value pair are added to the same group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>appname</para>
            /// </summary>
            [NameInMap("TagName")]
            [Validation(Required=false)]
            public string TagName { get; set; }

            /// <summary>
            /// <para>The tag values of the cloud resources. Set the value of N to 1.</para>
            /// <remarks>
            /// <para> If you set the <c>MatchExpress.N.TagValueMatchFunction</c> parameter, you must also set the <c>MatchExpress.N.TagValue</c> parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>instance</para>
            /// </summary>
            [NameInMap("TagValue")]
            [Validation(Required=false)]
            public string TagValue { get; set; }

            /// <summary>
            /// <para>The method that is used to match the tag values of the cloud resources. Set the value of N to 1. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>contains: contains</description></item>
            /// <item><description>startWith: starts with a prefix</description></item>
            /// <item><description>endWith: ends with a suffix</description></item>
            /// <item><description>notContains: does not contain</description></item>
            /// <item><description>equals: equals</description></item>
            /// <item><description>all: matches all</description></item>
            /// </list>
            /// <remarks>
            /// <para> If you set the <c>MatchExpress.N.TagValueMatchFunction</c> parameter, you must also set the <c>MatchExpress.N.TagValue</c> parameter.</para>
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
        /// <para>The relationship between the conditional expressions for the tag values of the cloud resources. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>and (default value)</description></item>
        /// <item><description>or</description></item>
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
        /// <para>The tag keys of the cloud resources.</para>
        /// <para>For more information about how to obtain tag keys, see <a href="https://help.aliyun.com/document_detail/145558.html">DescribeTagKeyList</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs_instance</para>
        /// </summary>
        [NameInMap("TagKey")]
        [Validation(Required=false)]
        public string TagKey { get; set; }

        /// <summary>
        /// <para>The ID of the region to which the tags belong.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("TagRegionId")]
        [Validation(Required=false)]
        public string TagRegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>85****</para>
        /// </summary>
        [NameInMap("TemplateIdList")]
        [Validation(Required=false)]
        public List<string> TemplateIdList { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class PutContactGroupRequest : TeaModel {
        /// <summary>
        /// <para>The name of the alert contact group.</para>
        /// <para>For information about how to obtain the name of an alert contact group, see <a href="https://help.aliyun.com/document_detail/114922.html">DescribeContactGroupList</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECS_Group</para>
        /// </summary>
        [NameInMap("ContactGroupName")]
        [Validation(Required=false)]
        public string ContactGroupName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Alice</para>
        /// </summary>
        [NameInMap("ContactNames")]
        [Validation(Required=false)]
        public List<string> ContactNames { get; set; }

        /// <summary>
        /// <para>The description of the alert contact group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECS_Alert_Group</para>
        /// </summary>
        [NameInMap("Describe")]
        [Validation(Required=false)]
        public string Describe { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the weekly report subscription feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The weekly report subscription feature is enabled.</description></item>
        /// <item><description>false: The weekly report subscription feature is disabled.</description></item>
        /// </list>
        /// <remarks>
        /// <para> You can enable the weekly report subscription only for an Alibaba Cloud account that has at least five Elastic Compute Service (ECS) instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableSubscribed")]
        [Validation(Required=false)]
        public bool? EnableSubscribed { get; set; }

    }

}

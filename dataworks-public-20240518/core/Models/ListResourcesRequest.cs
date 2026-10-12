// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListResourcesRequest : TeaModel {
        /// <summary>
        /// <para>The name of the file resource. Fuzzy match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the owner, which is the UID of the workspace administrator account. You can log on to the Alibaba Cloud Management Console and view the account UID in the Security Management section of Account Management.</para>
        /// 
        /// <b>Example:</b>
        /// <para>110755000425XXXX</para>
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// <para>The number of the page to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the DataWorks workspace. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the workspace configuration page to obtain the workspace ID. This parameter specifies the DataWorks workspace for the API operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10002</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The filter condition for the resource type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Python</description></item>
        /// <item><description>Jar</description></item>
        /// <item><description>Archive</description></item>
        /// <item><description>File</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Python</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}

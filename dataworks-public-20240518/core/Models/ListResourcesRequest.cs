// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListResourcesRequest : TeaModel {
        /// <summary>
        /// <para>The name of the file resource. Supports fuzzy search.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account used by the workspace administrator. You can log on to the Alibaba Cloud Management Console and view the ID on the Security Settings page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>110755000425XXXX</para>
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// <para>The page number of the data to retrieve, used for pagination.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The page number of the data to retrieve, used for pagination.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The DataWorks workspace ID. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the Workspace page to query the ID.</para>
        /// <para>You must configure this parameter to specify the DataWorks workspace to which the API operation is applied.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10002</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The resource type. This parameter specifies a filter condition.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Python</description></item>
        /// <item><description>Jar</description></item>
        /// <item><description>Archive</description></item>
        /// <item><description>File</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>python</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}

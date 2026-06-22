// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageRepoListRequest : TeaModel {
        /// <summary>
        /// <para>The page number of the page to return. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The search field. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>repoName</b>: image repository name</description></item>
        /// <item><description><b>repoNamespace</b>: image repository namespace</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter takes effect only when <b>OperateType</b> is set to <b>other</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>repoName</para>
        /// </summary>
        [NameInMap("FieldName")]
        [Validation(Required=false)]
        public string FieldName { get; set; }

        /// <summary>
        /// <para>The value of the search field.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when <b>OperateType</b> is set to <b>other</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>zeus</para>
        /// </summary>
        [NameInMap("FieldValue")]
        [Validation(Required=false)]
        public string FieldValue { get; set; }

        /// <summary>
        /// <para>The operation type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>count</b>: statistics</description></item>
        /// <item><description><b>other</b>: other.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>count</para>
        /// </summary>
        [NameInMap("OperateType")]
        [Validation(Required=false)]
        public string OperateType { get; set; }

        /// <summary>
        /// <para>The number of entries per page in a paged query. Default value: 20. If you leave this parameter empty, 20 entries are returned per page during paging.</para>
        /// <remarks>
        /// <para>Set PageSize to a non-empty value.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The name of the image repository.</para>
        /// 
        /// <b>Example:</b>
        /// <para>script7</para>
        /// </summary>
        [NameInMap("RepoName")]
        [Validation(Required=false)]
        public string RepoName { get; set; }

        /// <summary>
        /// <para>The namespace of the container image repository.</para>
        /// 
        /// <b>Example:</b>
        /// <para>libssh2</para>
        /// </summary>
        [NameInMap("RepoNamespace")]
        [Validation(Required=false)]
        public string RepoNamespace { get; set; }

        /// <summary>
        /// <para>Specifies whether the item is selected. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: No.</description></item>
        /// <item><description><b>1</b>: Yes.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Selected")]
        [Validation(Required=false)]
        public int? Selected { get; set; }

        /// <summary>
        /// <para>The dimension of the defense switch configuration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>image_repo</b>: image repository ID.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>image_repo</para>
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

        /// <summary>
        /// <para>The type of the defense switch. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>image_repo</b>: image repository defense.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>image_repo</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}

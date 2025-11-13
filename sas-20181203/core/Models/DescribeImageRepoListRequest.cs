// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageRepoListRequest : TeaModel {
        /// <summary>
        /// <para>The number of the page to return. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The name of the field that is used for the query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>repoName</b>: the name of the image repository</description></item>
        /// <item><description><b>repoNamespace</b>: the namespace to which the image repository belongs</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter takes effect only when the <b>OperateType</b> parameter is set to <b>other</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>repoName</para>
        /// </summary>
        [NameInMap("FieldName")]
        [Validation(Required=false)]
        public string FieldName { get; set; }

        /// <summary>
        /// <para>The value of the field that is used for the query.</para>
        /// <remarks>
        /// <para> This parameter takes effect only when the <b>OperateType</b> parameter is set to <b>other</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>zeus</para>
        /// </summary>
        [NameInMap("FieldValue")]
        [Validation(Required=false)]
        public string FieldValue { get; set; }

        /// <summary>
        /// <para>The type of the operation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>count</b>: counts statistics</description></item>
        /// <item><description><b>other</b>: others</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>count</para>
        /// </summary>
        [NameInMap("OperateType")]
        [Validation(Required=false)]
        public string OperateType { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: 20. If you leave this parameter empty, 20 entries are returned on each page.</para>
        /// <remarks>
        /// <para> We recommend that you do not leave this parameter empty.</para>
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
        /// <para>The namespace to which the image repository belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>libssh2</para>
        /// </summary>
        [NameInMap("RepoNamespace")]
        [Validation(Required=false)]
        public string RepoNamespace { get; set; }

        /// <summary>
        /// <para>Whether it is selected. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: NO</description></item>
        /// <item><description><b>1</b>: YES</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Selected")]
        [Validation(Required=false)]
        public int? Selected { get; set; }

        /// <summary>
        /// <para>The condition by which the feature is applied. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>image_repo</b>: the ID of the image repository</description></item>
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
        /// <para>The type of the feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>image_repo</b>: image repository protection</description></item>
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

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class SearchFileRequest : TeaModel {
        /// <summary>
        /// <para>The drive ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("drive_id")]
        [Validation(Required=false)]
        public string DriveId { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// 
        /// <b>Example:</b>
        /// <para>url,thumbnail</para>
        /// </summary>
        [NameInMap("fields")]
        [Validation(Required=false)]
        [Obsolete]
        public string Fields { get; set; }

        /// <summary>
        /// <para>The maximum number of results to return. Valid values: 1 to 100.</para>
        /// <para>The number of returned results must be less than or equal to the specified number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. You do not need to specify this parameter for the first request. You must specify the token that is obtained from the previous query as the value of marker.\
        /// By default, this parameter is left empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NWQ1Yjk4YmI1ZDRlYmU1Y2E0YWE0NmJhYWJmODBhNDQ2NzhlMTRhMg</para>
        /// </summary>
        [NameInMap("marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

        /// <summary>
        /// <para>The field by which to sort the returned results. Default value: created_at. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>created_at: sorts the results by the time when the file was created.</description></item>
        /// <item><description>updated_at: sorts the results by the time when the file was modified.</description></item>
        /// <item><description>size: sorts the results by the size of the file.</description></item>
        /// <item><description>name: sorts the results by the name of the file.</description></item>
        /// </list>
        /// <para>The order in which you want to sort the returned results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ASC: sorts the results in ascending order.</description></item>
        /// <item><description>DESC: sorts the results in descending order.</description></item>
        /// </list>
        /// <para>You must specify this parameter in the \<field name> \<ASC or DESC> format. Separate multiple field names with commas (,). A preceding field has a higher priority than a following field. Examples:</para>
        /// <list type="bullet">
        /// <item><description>If you want to sort the results based on the file name in ascending order, set this parameter to &quot;name ASC&quot;.</description></item>
        /// <item><description>If you want to sort the results based on the creation time in descending order, set this parameter to &quot;created_at DESC&quot;.</description></item>
        /// <item><description>If you want to sort the results based on the creation time in descending order first, and then sort the results based on the file name in ascending order if the creation time is the same, set this parameter to &quot;created_at DESC,name ASC&quot;.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>name</para>
        /// </summary>
        [NameInMap("order_by")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <para>The search condition. Fuzzy searches based on the file name or directory name are supported. The search condition can be up to 4,096 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>not name=123</para>
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        [NameInMap("recursive")]
        [Validation(Required=false)]
        public bool? Recursive { get; set; }

        /// <summary>
        /// <para>Specifies whether to return the total number of retrieved files.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("return_total_count")]
        [Validation(Required=false)]
        public bool? ReturnTotalCount { get; set; }

        [NameInMap("thumbnail_processes")]
        [Validation(Required=false)]
        public Dictionary<string, ImageProcess> ThumbnailProcesses { get; set; }

    }

}

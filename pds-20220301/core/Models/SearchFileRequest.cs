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

        /// <summary>
        /// <b>Example:</b>
        /// <para>url,thumbnail</para>
        /// </summary>
        [NameInMap("fields")]
        [Validation(Required=false)]
        public string Fields { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return. Valid values: 1 to 100.</para>
        /// <para>The number of returned entries must be less than or equal to the value of this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// <para>The name of the entry after which the list begins. Entries whose names are alphabetically after the value of this parameter are returned. If you do not specify this parameter, all entries are returned.\
        /// This parameter is left empty by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NWQ1Yjk4YmI1ZDRlYmU1Y2E0YWE0NmJhYWJmODBhNDQ2NzhlMTRhMg</para>
        /// </summary>
        [NameInMap("marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

        /// <summary>
        /// <para>The field by which to sort the returned entries. Default value: created_at. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>created_at: sorts the entries by creation time.</description></item>
        /// <item><description>updated_at: sorts the entries by update time.</description></item>
        /// <item><description>size: sorts the entries by file size.</description></item>
        /// <item><description>name: sorts the entries by file name.</description></item>
        /// </list>
        /// <para>The order in which you want to sort the returned entries. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ASC: ascending order</description></item>
        /// <item><description>DESC: descending order</description></item>
        /// </list>
        /// <para>You must specify this parameter in the \<field> \<ASC or DESC> format. Separate multiple fields with commas (,). A preceding field has a higher priority than a following field. Examples:</para>
        /// <list type="bullet">
        /// <item><description>If you want to sort the entries by file name in ascending order, set this parameter to &quot;name ASC&quot;.</description></item>
        /// <item><description>If you want to sort the entries by creation time in descending order, set this parameter to &quot;created_at DESC&quot;.</description></item>
        /// <item><description>If you want to sort the entries by creation time in descending order and sort the entries by file name in ascending order in case of the same creation time, set this parameter to &quot;created_at DESC,name ASC&quot;.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>name</para>
        /// </summary>
        [NameInMap("order_by")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <para>The search conditions. Fuzzy searches based on the file name or directory name are supported. The value of this parameter can be up to 4,096 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>not name=123</para>
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform recursive search on a folder that is specified by setting parent_file_id in the query parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
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

        /// <summary>
        /// <para>The thumbnail configurations. Up to five thumbnails can be returned at a time. The value contains key-value pairs. You can customize the keys. The URL of a thumbnail is returned based on the key.</para>
        /// </summary>
        [NameInMap("thumbnail_processes")]
        [Validation(Required=false)]
        public Dictionary<string, ImageProcess> ThumbnailProcesses { get; set; }

    }

}

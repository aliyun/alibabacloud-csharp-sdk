// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class ListRecyclebinRequest : TeaModel {
        /// <summary>
        /// <para>The drive ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("drive_id")]
        [Validation(Required=false)]
        public string DriveId { get; set; }

        /// <summary>
        /// <para>Specifies the returned fields.</para>
        /// <para>1\. If you set this parameter to \*, all fields of the file are returned.</para>
        /// <para>2\. If you set this parameter to a null value or leave this parameter empty, the fields, such as file creator, file modifier, and custom tags, are not returned.</para>
        /// <para>The default value is a null value, which indicates that only some fields are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("fields")]
        [Validation(Required=false)]
        public string Fields { get; set; }

        /// <summary>
        /// <para>The maximum number of results to return. Valid values: 1 to 200. Default value: 50.</para>
        /// <para>The number of returned results must be less than or equal to the specified number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. You do not need to specify this parameter for the first request. You must specify the token that is obtained from the previous query as the value of marker. By default, this parameter is left empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NWQ1Yjk4YmI1ZDRlYmU1Y2E0YWE0NmJhYWJmODBhNDQ2NzhlMTRhMg</para>
        /// </summary>
        [NameInMap("marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

    }

}

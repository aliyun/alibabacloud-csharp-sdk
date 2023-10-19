// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class SearchFileRequest : TeaModel {
        /// <summary>
        /// The drive ID.
        /// </summary>
        [NameInMap("drive_id")]
        [Validation(Required=false)]
        public string DriveId { get; set; }

        [NameInMap("fields")]
        [Validation(Required=false)]
        public string Fields { get; set; }

        /// <summary>
        /// The maximum number of results to return. Valid values: 1 to 100.
        /// 
        /// The number of returned results must be less than or equal to the specified number.
        /// </summary>
        [NameInMap("limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// The pagination token that is used in the next request to retrieve a new page of results. You do not need to specify this parameter for the first request. You must specify the token that is obtained from the previous query as the value of marker.\
        /// By default, this parameter is left empty.
        /// </summary>
        [NameInMap("marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

        /// <summary>
        /// The field by which to sort the returned results. Default value: created_at. Valid values:
        /// 
        /// *   created_at: sorts the results by the time when the file was created.
        /// *   updated_at: sorts the results by the time when the file was modified.
        /// *   size: sorts the results by the size of the file.
        /// *   name: sorts the results by the name of the file.
        /// 
        /// The order in which you want to sort the returned results. Valid values:
        /// 
        /// *   ASC: sorts the results in ascending order.
        /// *   DESC: sorts the results in descending order.
        /// 
        /// You must specify this parameter in the \<field name> \<ASC or DESC> format. Separate multiple field names with commas (,). A preceding field has a higher priority than a following field. Examples:
        /// 
        /// *   If you want to sort the results based on the file name in ascending order, set this parameter to "name ASC".
        /// *   If you want to sort the results based on the creation time in descending order, set this parameter to "created_at DESC".
        /// *   If you want to sort the results based on the creation time in descending order first, and then sort the results based on the file name in ascending order if the creation time is the same, set this parameter to "created_at DESC,name ASC".
        /// </summary>
        [NameInMap("order_by")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// The search condition. Fuzzy searches based on the file name or directory name are supported. The search condition can be up to 4,096 characters in length.
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// Specifies whether to return the total number of retrieved files.
        /// </summary>
        [NameInMap("return_total_count")]
        [Validation(Required=false)]
        public bool? ReturnTotalCount { get; set; }

    }

}

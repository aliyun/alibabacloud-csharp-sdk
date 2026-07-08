// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class ListWarehouseRequest : TeaModel {
        /// <summary>
        /// <para>The maximum number of entries to return on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token from a previous response. Use this token to retrieve the next page of results. Omit this parameter for the first request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1d2db86sca4384811e0b5e8707e68181f</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>A list of warehouse instance IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cas-wh-uc-gl2bsq</para>
        /// </summary>
        [NameInMap("WarehouseInstanceIds")]
        [Validation(Required=false)]
        public List<string> WarehouseInstanceIds { get; set; }

        /// <summary>
        /// <para>A list of warehouse types.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pcaCaCert</para>
        /// </summary>
        [NameInMap("WarehouseTypes")]
        [Validation(Required=false)]
        public List<string> WarehouseTypes { get; set; }

    }

}

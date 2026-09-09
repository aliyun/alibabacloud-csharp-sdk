// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ListResourceRecordRequest : TeaModel {
        /// <summary>
        /// <para>Filters records by ID. Separate multiple IDs with commas (,). A maximum of 200 IDs are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>record-001,record-002</para>
        /// </summary>
        [NameInMap("ids")]
        [Validation(Required=false)]
        public string Ids { get; set; }

        /// <summary>
        /// <para>Specifies whether to include system built-in records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("includeSystemRecords")]
        [Validation(Required=false)]
        public bool? IncludeSystemRecords { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable JSON filter acceleration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("jsonFilterAcc")]
        [Validation(Required=false)]
        public bool? JsonFilterAcc { get; set; }

        /// <summary>
        /// <para>The JSON field path. Use this parameter together with jsonPathValue.</para>
        /// 
        /// <b>Example:</b>
        /// <para>$.status</para>
        /// </summary>
        [NameInMap("jsonPath")]
        [Validation(Required=false)]
        public string JsonPath { get; set; }

        /// <summary>
        /// <para>The filter value of the JSON field. Use this parameter together with jsonPath.</para>
        /// 
        /// <b>Example:</b>
        /// <para>enabled</para>
        /// </summary>
        [NameInMap("jsonPathValue")]
        [Validation(Required=false)]
        public string JsonPathValue { get; set; }

        /// <summary>
        /// <para>The start position of the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("offset")]
        [Validation(Required=false)]
        public int? Offset { get; set; }

        /// <summary>
        /// <para>Searches for the specified string in record content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("search")]
        [Validation(Required=false)]
        public string Search { get; set; }

        /// <summary>
        /// <para>The maximum number of records to return. Valid values: 1 to 200.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

        /// <summary>
        /// <para>Searches by JSON content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>status</para>
        /// </summary>
        [NameInMap("sjson")]
        [Validation(Required=false)]
        public string Sjson { get; set; }

        /// <summary>
        /// <para>Filters records by label.</para>
        /// 
        /// <b>Example:</b>
        /// <para>production</para>
        /// </summary>
        [NameInMap("tag")]
        [Validation(Required=false)]
        public string Tag { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class ListInventoryEntriesResponseBody : TeaModel {
        /// <summary>
        /// <para>The time when the request was sent.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-09-17T12:28:13Z</para>
        /// </summary>
        [NameInMap("CaptureTime")]
        [Validation(Required=false)]
        public string CaptureTime { get; set; }

        /// <summary>
        /// <para>The configurations of the component.</para>
        /// </summary>
        [NameInMap("Entries")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> Entries { get; set; }

        /// <summary>
        /// <para>The ID of the ECS instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp1cpoxxxwxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The returned value of NextToken is a pagination token, which can be used in the next request to retrieve a new page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gAAAAABfTgv5ewUWmNdJ3g7JVLvX70sPH90GZOVGC</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A81E4B2E-6B33-4BAE-9856-55DB7C893E01</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The version number of the component.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0</para>
        /// </summary>
        [NameInMap("SchemaVersion")]
        [Validation(Required=false)]
        public string SchemaVersion { get; set; }

        /// <summary>
        /// <para>The name of the component.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ACS:InstanceInformation</para>
        /// </summary>
        [NameInMap("TypeName")]
        [Validation(Required=false)]
        public string TypeName { get; set; }

    }

}

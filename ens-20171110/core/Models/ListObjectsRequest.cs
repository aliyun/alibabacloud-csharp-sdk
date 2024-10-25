// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class ListObjectsRequest : TeaModel {
        /// <summary>
        /// <para>The name of the bucket.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("BucketName")]
        [Validation(Required=false)]
        public string BucketName { get; set; }

        /// <summary>
        /// <para>The token used in this list operation. If the number of objects exceeds the value of MaxKeys, the NextContinuationToken is included in the response as the token for the next list operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test1.txt</para>
        /// </summary>
        [NameInMap("ContinuationToken")]
        [Validation(Required=false)]
        public string ContinuationToken { get; set; }

        /// <summary>
        /// <para>The encoding type of the object names in the response. Only URL encoding is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>url</para>
        /// </summary>
        [NameInMap("EncodingType")]
        [Validation(Required=false)]
        public string EncodingType { get; set; }

        /// <summary>
        /// <para>The position from which the list operation starts. If this parameter is specified, objects whose names are alphabetically greater than value of Marker are returned. The Marker parameter is used to list the returned objects by page, and its value must be smaller than 1,024 bytes in length.</para>
        /// <para>Even if the value specified for Marker does not exist in the list during a conditional query, the list starts from the object whose name is alphabetically greater than the value of Marker.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a</para>
        /// </summary>
        [NameInMap("Marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

        /// <summary>
        /// <para>The maximum number of objects to return. Valid values: 0 to 1000. Default value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MaxKeys")]
        [Validation(Required=false)]
        public long? MaxKeys { get; set; }

        /// <summary>
        /// <para>The prefix that must be included in the names of objects you want to list. If you specify a prefix to query objects, the returned object names contain the prefix.</para>
        /// <para>The value of the parameter must be less than 1,000 bytes in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b</para>
        /// </summary>
        [NameInMap("Prefix")]
        [Validation(Required=false)]
        public string Prefix { get; set; }

        /// <summary>
        /// <para>The position from which the list operation starts. If this parameter is specified, objects whose names are alphabetically greater than the value of StartAfter are returned. The StartAfter parameter is used to list the returned objects by page, and its value must be less than 1,000 bytes in length. Even if the value specified for StartAfter does not exist in the list during a conditional query, the list starts from the object whose name is alphabetically greater than the value of StartAfter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b</para>
        /// </summary>
        [NameInMap("StartAfter")]
        [Validation(Required=false)]
        public string StartAfter { get; set; }

    }

}

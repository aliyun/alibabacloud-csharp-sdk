// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class ListRayLogsRequest : TeaModel {
        /// <summary>
        /// <para>The bucket name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mybucket</para>
        /// </summary>
        [NameInMap("bucketName")]
        [Validation(Required=false)]
        public string BucketName { get; set; }

        /// <summary>
        /// <para>The character used to group object names. All objects whose names contain the specified prefix and between which the delimiter character appears for the first time are grouped as a set of elements (CommonPrefixes).</para>
        /// 
        /// <b>Example:</b>
        /// <para>/</para>
        /// </summary>
        [NameInMap("delimiter")]
        [Validation(Required=false)]
        public string Delimiter { get; set; }

        /// <summary>
        /// <para>The marker after which the returned objects are listed in alphabetical order.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test1.txt</para>
        /// </summary>
        [NameInMap("marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

        /// <summary>
        /// <para>The maximum number of objects to return. If the listing cannot be completed in a single request due to the max-keys setting, a NextMarker element is included in the response as the marker for the next listing request.</para>
        /// <para>Valid values: greater than 0 and less than 1000.</para>
        /// <para>Default value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("maxKeys")]
        [Validation(Required=false)]
        public long? MaxKeys { get; set; }

        /// <summary>
        /// <para>The prefix that the keys of the returned files must start with.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/w-xxxxxxx/ray/logs/rj-xxxxxxxxxx_default/</para>
        /// </summary>
        [NameInMap("prefix")]
        [Validation(Required=false)]
        public string Prefix { get; set; }

    }

}

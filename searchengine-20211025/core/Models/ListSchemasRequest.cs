// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ListSchemasRequest : TeaModel {
        /// <summary>
        /// The AccessKey ID of the MaxCompute data source.
        /// </summary>
        [NameInMap("accessKey")]
        [Validation(Required=false)]
        public string AccessKey { get; set; }

        /// <summary>
        /// The AccessKey secret of the MaxCompute data source.
        /// </summary>
        [NameInMap("accessSecret")]
        [Validation(Required=false)]
        public string AccessSecret { get; set; }

        /// <summary>
        /// The endpoint of the MaxCompute data source.
        /// </summary>
        [NameInMap("endpoint")]
        [Validation(Required=false)]
        public string Endpoint { get; set; }

        /// <summary>
        /// The namespace of the SARO data source.
        /// </summary>
        [NameInMap("namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// The shard name.
        /// </summary>
        [NameInMap("partition")]
        [Validation(Required=false)]
        public string Partition { get; set; }

        /// <summary>
        /// The name of the MaxCompute project that is used as the data source.
        /// </summary>
        [NameInMap("project")]
        [Validation(Required=false)]
        public string Project { get; set; }

        /// <summary>
        /// The name of the MaxCompute table that is used as the data source.
        /// </summary>
        [NameInMap("table")]
        [Validation(Required=false)]
        public string Table { get; set; }

        /// <summary>
        /// The type of the data source. Valid values: odps, swift, saro, oss, and unKnow.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}

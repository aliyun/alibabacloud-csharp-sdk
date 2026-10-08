// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListHistoryDeployVersionResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The additional information that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PackageVersionList")]
        [Validation(Required=false)]
        public ListHistoryDeployVersionResponseBodyPackageVersionList PackageVersionList { get; set; }
        public class ListHistoryDeployVersionResponseBodyPackageVersionList : TeaModel {
            [NameInMap("PackageVersion")]
            [Validation(Required=false)]
            public List<ListHistoryDeployVersionResponseBodyPackageVersionListPackageVersion> PackageVersion { get; set; }
            public class ListHistoryDeployVersionResponseBodyPackageVersionListPackageVersion : TeaModel {
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("PackageVersion")]
                [Validation(Required=false)]
                public string PackageVersion { get; set; }

                [NameInMap("PublicUrl")]
                [Validation(Required=false)]
                public string PublicUrl { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

                [NameInMap("WarUrl")]
                [Validation(Required=false)]
                public string WarUrl { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D16979DC-4D42-************</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

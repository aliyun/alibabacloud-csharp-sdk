// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListPrivateRegistryTypeResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about image repository types.</para>
        /// </summary>
        [NameInMap("RegistryTypeInfos")]
        [Validation(Required=false)]
        public List<ListPrivateRegistryTypeResponseBodyRegistryTypeInfos> RegistryTypeInfos { get; set; }
        public class ListPrivateRegistryTypeResponseBodyRegistryTypeInfos : TeaModel {
            /// <summary>
            /// <para>The number of image repositories.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            /// <summary>
            /// <para>The type of the image repository. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>acr</b>: ACR.</description></item>
            /// <item><description><b>harbor</b>: Harbor.</description></item>
            /// <item><description><b>quay</b>: Quay.</description></item>
            /// <item><description><b>CI/CD</b>: Jenkins.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>harbor</para>
            /// </summary>
            [NameInMap("RegistryType")]
            [Validation(Required=false)]
            public string RegistryType { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request. The China Chinese Cloud generates a unique identifier for each request. You can use the ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>24A20733-10A0-4AF6-BE6B-E3322413****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

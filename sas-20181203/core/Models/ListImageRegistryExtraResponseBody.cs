// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListImageRegistryExtraResponseBody : TeaModel {
        /// <summary>
        /// <para>The additional configuration information about the image repository.</para>
        /// </summary>
        [NameInMap("ImageRegistryExtraInfos")]
        [Validation(Required=false)]
        public List<ListImageRegistryExtraResponseBodyImageRegistryExtraInfos> ImageRegistryExtraInfos { get; set; }
        public class ListImageRegistryExtraResponseBodyImageRegistryExtraInfos : TeaModel {
            /// <summary>
            /// <para>The ID of the Alibaba Cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>176618589410****</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            /// <summary>
            /// <para>The authorization token.</para>
            /// 
            /// <b>Example:</b>
            /// <para>64ad8ddf-6a4c-46b5-8dea-b105a06bd534</para>
            /// </summary>
            [NameInMap("AuthToken")]
            [Validation(Required=false)]
            public string AuthToken { get; set; }

            /// <summary>
            /// <para>The configuration ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>113441</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The namespace of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>public-goods</para>
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// <para>The ID of the image repository.</para>
            /// 
            /// <b>Example:</b>
            /// <para>25363</para>
            /// </summary>
            [NameInMap("RegistryId")]
            [Validation(Required=false)]
            public long? RegistryId { get; set; }

            /// <summary>
            /// <para>The type of the image repository. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>acr</b>: Container Registry.</description></item>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>09969D2C-4FAD-429E-BFBF-9A60DEF8****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

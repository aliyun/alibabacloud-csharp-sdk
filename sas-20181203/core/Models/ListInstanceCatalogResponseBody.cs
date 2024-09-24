// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListInstanceCatalogResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0D42A83F-CE33-5F54-A5AE-05DA39F59E1B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>An array that consists of the asset types by service provider.</para>
        /// </summary>
        [NameInMap("Vendors")]
        [Validation(Required=false)]
        public List<ListInstanceCatalogResponseBodyVendors> Vendors { get; set; }
        public class ListInstanceCatalogResponseBodyVendors : TeaModel {
            /// <summary>
            /// <para>An array that consists of asset types.</para>
            /// </summary>
            [NameInMap("InstanceTypes")]
            [Validation(Required=false)]
            public List<ListInstanceCatalogResponseBodyVendorsInstanceTypes> InstanceTypes { get; set; }
            public class ListInstanceCatalogResponseBodyVendorsInstanceTypes : TeaModel {
                /// <summary>
                /// <para>An array that consists of asset subtypes.</para>
                /// </summary>
                [NameInMap("InstanceSubTypes")]
                [Validation(Required=false)]
                public List<ListInstanceCatalogResponseBodyVendorsInstanceTypesInstanceSubTypes> InstanceSubTypes { get; set; }
                public class ListInstanceCatalogResponseBodyVendorsInstanceTypesInstanceSubTypes : TeaModel {
                    /// <summary>
                    /// <para>The name of the asset subtype.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SECURITY_GROUP</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <para>The name of the asset type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ECS</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The name of the service provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ALIYUN</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

    }

}

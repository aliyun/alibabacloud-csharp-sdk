// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class MLServiceParam : TeaModel {
        /// <summary>
        /// <para>The microservice description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SampleService</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The model configuration that the microservice depends on.</para>
        /// </summary>
        [NameInMap("model")]
        [Validation(Required=false)]
        public MLServiceParamModel Model { get; set; }
        public class MLServiceParamModel : TeaModel {
            /// <summary>
            /// <para>The model resource ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxx</para>
            /// </summary>
            [NameInMap("modelResourceId")]
            [Validation(Required=false)]
            public string ModelResourceId { get; set; }

            /// <summary>
            /// <para>The model resource type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx_type</para>
            /// </summary>
            [NameInMap("modelResourceType")]
            [Validation(Required=false)]
            public string ModelResourceType { get; set; }

        }

        /// <summary>
        /// <para>The microservice name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>service_name</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The microservice EPS resource configuration.</para>
        /// </summary>
        [NameInMap("resource")]
        [Validation(Required=false)]
        public MLServiceParamResource Resource { get; set; }
        public class MLServiceParamResource : TeaModel {
            /// <summary>
            /// <para>The maximum CPU resource limit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("cpuLimit")]
            [Validation(Required=false)]
            public int? CpuLimit { get; set; }

            /// <summary>
            /// <para>The required GPU memory size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("gpu")]
            [Validation(Required=false)]
            public int? Gpu { get; set; }

            /// <summary>
            /// <para>The maximum memory resources limit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>64</para>
            /// </summary>
            [NameInMap("memoryLimit")]
            [Validation(Required=false)]
            public int? MemoryLimit { get; set; }

            /// <summary>
            /// <para>The number of microservice replicas.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("replica")]
            [Validation(Required=false)]
            public int? Replica { get; set; }

        }

        /// <summary>
        /// <para>The microservice type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sls_builtin</para>
        /// </summary>
        [NameInMap("serviceType")]
        [Validation(Required=false)]
        public string ServiceType { get; set; }

        /// <summary>
        /// <para>The microservice status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>running</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The microservice update time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1695090077</para>
        /// </summary>
        [NameInMap("updateTimestamp")]
        [Validation(Required=false)]
        public long? UpdateTimestamp { get; set; }

    }

}

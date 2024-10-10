// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribeAppServiceDetailRequest : TeaModel {
        /// <summary>
        /// <para>6dcc8c9e-d3da-478a-a066-86dcf820\<em>\</em>\<em>\</em></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6dcc8c9e-d3da-478a-a066-86dcf820****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("NacosInstanceId")]
        [Validation(Required=false)]
        public string NacosInstanceId { get; set; }

        [NameInMap("NacosNamespaceId")]
        [Validation(Required=false)]
        public string NacosNamespaceId { get; set; }

        /// <summary>
        /// <para>springCloud</para>
        /// 
        /// <b>Example:</b>
        /// <para>springCloud</para>
        /// </summary>
        [NameInMap("ServiceGroup")]
        [Validation(Required=false)]
        public string ServiceGroup { get; set; }

        /// <summary>
        /// <para>edas.service.provider</para>
        /// 
        /// <b>Example:</b>
        /// <para>edas.service.provider</para>
        /// </summary>
        [NameInMap("ServiceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

        /// <summary>
        /// <para>springCloud</para>
        /// 
        /// <b>Example:</b>
        /// <para>springCloud</para>
        /// </summary>
        [NameInMap("ServiceType")]
        [Validation(Required=false)]
        public string ServiceType { get; set; }

        /// <summary>
        /// <para>1.0.0</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0.0</para>
        /// </summary>
        [NameInMap("ServiceVersion")]
        [Validation(Required=false)]
        public string ServiceVersion { get; set; }

    }

}

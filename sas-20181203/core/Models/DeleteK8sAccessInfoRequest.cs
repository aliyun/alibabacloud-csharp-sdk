// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DeleteK8sAccessInfoRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is deprecated and can be ignored.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("AliyunYundunGatewayApiName")]
        [Validation(Required=false)]
        public string AliyunYundunGatewayApiName { get; set; }

        /// <summary>
        /// <para>This parameter is deprecated and can be ignored.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("AliyunYundunGatewayPopName")]
        [Validation(Required=false)]
        public string AliyunYundunGatewayPopName { get; set; }

        /// <summary>
        /// <para>This parameter is deprecated and can be ignored.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("AliyunYundunGatewayProjectName")]
        [Validation(Required=false)]
        public string AliyunYundunGatewayProjectName { get; set; }

        /// <summary>
        /// <para>The default value generated when accessing Kubernetes. You can obtain the ID by calling the <a href="https://help.aliyun.com/document_detail/2623602.html">GenerateK8sAccessInfo</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

    }

}

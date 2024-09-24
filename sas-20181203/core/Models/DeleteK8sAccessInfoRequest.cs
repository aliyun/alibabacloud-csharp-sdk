// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DeleteK8sAccessInfoRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("AliyunYundunGatewayApiName")]
        [Validation(Required=false)]
        public string AliyunYundunGatewayApiName { get; set; }

        /// <summary>
        /// <para>This parameter is deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("AliyunYundunGatewayPopName")]
        [Validation(Required=false)]
        public string AliyunYundunGatewayPopName { get; set; }

        /// <summary>
        /// <para>This parameter is deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("AliyunYundunGatewayProjectName")]
        [Validation(Required=false)]
        public string AliyunYundunGatewayProjectName { get; set; }

        /// <summary>
        /// <para>The ID generated when Kubernetes is connected. You can call the GenerateK8sAccessInfo operation to query the ID.</para>
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

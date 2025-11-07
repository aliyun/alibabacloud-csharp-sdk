// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class UpdateApplicationGroupRequest : TeaModel {
        /// <summary>
        /// <para>The application name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MyApplication</para>
        /// </summary>
        [NameInMap("ApplicationName")]
        [Validation(Required=false)]
        public string ApplicationName { get; set; }

        [NameInMap("DeployedRevisionId")]
        [Validation(Required=false)]
        public string DeployedRevisionId { get; set; }

        /// <summary>
        /// <para>The name of the application group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MyApplicationGroup</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The new name of the application group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UpdateMyApplicationGroup</para>
        /// </summary>
        [NameInMap("NewName")]
        [Validation(Required=false)]
        public string NewName { get; set; }

        /// <summary>
        /// <para>The name of the configuration update operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/business/v1/product/spus/{spu_id}</para>
        /// </summary>
        [NameInMap("OperationName")]
        [Validation(Required=false)]
        public string OperationName { get; set; }

        /// <summary>
        /// <para>The JSON string that consists of a set of parameters. Default value: {}.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;username&quot;: &quot;xx&quot;}</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public Dictionary<string, object> Parameters { get; set; }

        /// <summary>
        /// <para>The region ID. Set the value to cn-hangzhou.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}

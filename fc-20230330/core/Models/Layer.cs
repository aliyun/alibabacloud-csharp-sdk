// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class Layer : TeaModel {
        /// <summary>
        /// <para>The permission of the layer. Valid value: 0 and 1. 0 specifies that the layer is private, and 1 specifies that the layer is public. By default, public layers are public. Custom layers can be set to private or public.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("acl")]
        [Validation(Required=false)]
        public string Acl { get; set; }

        /// <summary>
        /// <para>The information about the code package of the layer.</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public OutputCodeLocation Code { get; set; }

        /// <summary>
        /// <para>The crc64 verification code of the layer code package, which is calculated based on ECMA-182.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2825179536350****</para>
        /// </summary>
        [NameInMap("codeChecksum")]
        [Validation(Required=false)]
        public string CodeChecksum { get; set; }

        /// <summary>
        /// <para>The size of the layer code package. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>421</para>
        /// </summary>
        [NameInMap("codeSize")]
        [Validation(Required=false)]
        public long? CodeSize { get; set; }

        /// <summary>
        /// <para>The runtimes that are supported by the layer.</para>
        /// </summary>
        [NameInMap("compatibleRuntime")]
        [Validation(Required=false)]
        public List<string> CompatibleRuntime { get; set; }

        /// <summary>
        /// <para>The time when the layer version was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-03-30T11:08:00Z</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The description of the layer version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>My first layer</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the layer.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MyLayer</para>
        /// </summary>
        [NameInMap("layerName")]
        [Validation(Required=false)]
        public string LayerName { get; set; }

        /// <summary>
        /// <para>The name of the resource in the layer version. The name is in the acs:fc:{region}:{accountID}:layers/{layerName}/versions/{layerVersion} format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:fc:cn-beijing:186824xxxxxx:layers/fc_layer/versions/1</para>
        /// </summary>
        [NameInMap("layerVersionArn")]
        [Validation(Required=false)]
        public string LayerVersionArn { get; set; }

        /// <summary>
        /// <para>The license agreement.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Apache</para>
        /// </summary>
        [NameInMap("license")]
        [Validation(Required=false)]
        public string License { get; set; }

        /// <summary>
        /// <para>The layer version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public int? Version { get; set; }

    }

}

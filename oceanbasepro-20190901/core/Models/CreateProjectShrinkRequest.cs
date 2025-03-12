// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class CreateProjectShrinkRequest : TeaModel {
        [NameInMap("CommonTransferConfig")]
        [Validation(Required=false)]
        public string CommonTransferConfigShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableFullTransfer")]
        [Validation(Required=false)]
        public bool? EnableFullTransfer { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableFullVerify")]
        [Validation(Required=false)]
        public bool? EnableFullVerify { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableIncrTransfer")]
        [Validation(Required=false)]
        public bool? EnableIncrTransfer { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableReverseIncrTransfer")]
        [Validation(Required=false)]
        public bool? EnableReverseIncrTransfer { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableStructTransfer")]
        [Validation(Required=false)]
        public bool? EnableStructTransfer { get; set; }

        [NameInMap("FullTransferConfig")]
        [Validation(Required=false)]
        public string FullTransferConfigShrink { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("IncrTransferConfig")]
        [Validation(Required=false)]
        public string IncrTransferConfigShrink { get; set; }

        [NameInMap("LabelIds")]
        [Validation(Required=false)]
        public string LabelIdsShrink { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>open_api_create_project/oacp_xxx</para>
        /// </summary>
        [NameInMap("OssKey")]
        [Validation(Required=false)]
        public string OssKey { get; set; }

        [NameInMap("ReverseIncrTransferConfig")]
        [Validation(Required=false)]
        public string ReverseIncrTransferConfigShrink { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e_4j0cz****</para>
        /// </summary>
        [NameInMap("SinkEndpointId")]
        [Validation(Required=false)]
        public string SinkEndpointId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e_4j0c12z****</para>
        /// </summary>
        [NameInMap("SourceEndpointId")]
        [Validation(Required=false)]
        public string SourceEndpointId { get; set; }

        [NameInMap("StructTransferConfig")]
        [Validation(Required=false)]
        public string StructTransferConfigShrink { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("TransferMapping")]
        [Validation(Required=false)]
        public string TransferMappingShrink { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MIGRATION</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("UseOss")]
        [Validation(Required=false)]
        public bool? UseOss { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>g_abcdefj***</para>
        /// </summary>
        [NameInMap("WorkerGradeId")]
        [Validation(Required=false)]
        public string WorkerGradeId { get; set; }

    }

}

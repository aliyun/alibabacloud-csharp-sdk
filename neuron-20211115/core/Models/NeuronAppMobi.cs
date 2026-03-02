// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class NeuronAppMobi : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("appId")]
        [Validation(Required=false)]
        public long? AppId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sda</para>
        /// </summary>
        [NameInMap("artifactUrl")]
        [Validation(Required=false)]
        public string ArtifactUrl { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sda</para>
        /// </summary>
        [NameInMap("commitId")]
        [Validation(Required=false)]
        public string CommitId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("enterpriseId")]
        [Validation(Required=false)]
        public long? EnterpriseId { get; set; }

        [NameInMap("gmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        [NameInMap("gmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1343424</para>
        /// </summary>
        [NameInMap("mobiUserId")]
        [Validation(Required=false)]
        public string MobiUserId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>sda</para>
        /// </summary>
        [NameInMap("moduleId")]
        [Validation(Required=false)]
        public string ModuleId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>sda</para>
        /// </summary>
        [NameInMap("moduleName")]
        [Validation(Required=false)]
        public string ModuleName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>sda</para>
        /// </summary>
        [NameInMap("schemaVersion")]
        [Validation(Required=false)]
        public string SchemaVersion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>NEW</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>sda</para>
        /// </summary>
        [NameInMap("storeUrl")]
        [Validation(Required=false)]
        public string StoreUrl { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sdasdaddsad</para>
        /// </summary>
        [NameInMap("token")]
        [Validation(Required=false)]
        public string Token { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1.0.0.0</para>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}

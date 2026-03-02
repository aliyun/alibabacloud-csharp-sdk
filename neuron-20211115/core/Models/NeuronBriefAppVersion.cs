// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class NeuronBriefAppVersion : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1343424</para>
        /// </summary>
        [NameInMap("accountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("appId")]
        [Validation(Required=false)]
        public long? AppId { get; set; }

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

        [NameInMap("manageType")]
        [Validation(Required=false)]
        public string ManageType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>commit_pckesd7d_20230227215101</para>
        /// </summary>
        [NameInMap("mobiCommitId")]
        [Validation(Required=false)]
        public string MobiCommitId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("mobiId")]
        [Validation(Required=false)]
        public long? MobiId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>module_tvtpydeq</para>
        /// </summary>
        [NameInMap("mobiModuleId")]
        [Validation(Required=false)]
        public string MobiModuleId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>sda</para>
        /// </summary>
        [NameInMap("mobiUrl")]
        [Validation(Required=false)]
        public string MobiUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("productId")]
        [Validation(Required=false)]
        public long? ProductId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DRAFT</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0.0.0</para>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}

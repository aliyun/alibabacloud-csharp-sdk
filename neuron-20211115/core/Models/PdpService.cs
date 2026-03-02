// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class PdpService : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>121321412341</para>
        /// </summary>
        [NameInMap("accountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>员工管理</para>
        /// </summary>
        [NameInMap("alias")]
        [Validation(Required=false)]
        public string Alias { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dev</para>
        /// </summary>
        [NameInMap("codeBranch")]
        [Validation(Required=false)]
        public string CodeBranch { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>员工管理</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("enterpriseId")]
        [Validation(Required=false)]
        public long? EnterpriseId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>SDK</para>
        /// </summary>
        [NameInMap("extraInfo")]
        [Validation(Required=false)]
        public string ExtraInfo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="mailto:git@gitlab.alibaba-inc.com">git@gitlab.alibaba-inc.com</a>:neuron/manager-developer.git</para>
        /// </summary>
        [NameInMap("gitRepo")]
        [Validation(Required=false)]
        public string GitRepo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2022-2-22 11:11:2</para>
        /// </summary>
        [NameInMap("gmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2022-2-22 11:11:2</para>
        /// </summary>
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
        /// <para><a href="https://cd.aone.alibaba-inc.com/ec/pipelines/44156?spm=a2o8d.aone_cd_assets_pages_pipeline_index.0.0.68b81c05WLmX79&name=%E3%80%90%E6%B5%8B%E8%AF%95%E3%80%91neuron-developer%E6%9D%AD%E5%B7%9E">https://cd.aone.alibaba-inc.com/ec/pipelines/44156?spm=a2o8d.aone_cd_assets_pages_pipeline_index.0.0.68b81c05WLmX79&amp;name=%E3%80%90%E6%B5%8B%E8%AF%95%E3%80%91neuron-developer%E6%9D%AD%E5%B7%9E</a></para>
        /// </summary>
        [NameInMap("jumpUrl")]
        [Validation(Required=false)]
        public string JumpUrl { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>employee</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>INNER</para>
        /// </summary>
        [NameInMap("orgType")]
        [Validation(Required=false)]
        public string OrgType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pbcId")]
        [Validation(Required=false)]
        public long? PbcId { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Active</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SDK</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}

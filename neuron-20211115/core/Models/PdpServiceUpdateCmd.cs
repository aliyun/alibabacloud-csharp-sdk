// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class PdpServiceUpdateCmd : TeaModel {
        /// <summary>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://aone.alibaba-inc.com/appcenter/app/onlinetask/SUBMIT_RESOURCE_APPLY?appId=195041">https://aone.alibaba-inc.com/appcenter/app/onlinetask/SUBMIT_RESOURCE_APPLY?appId=195041</a></para>
        /// </summary>
        [NameInMap("jumpUrl")]
        [Validation(Required=false)]
        public string JumpUrl { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class CheckRecallManagementServiceRequest : TeaModel {
        /// <summary>
        /// <para>The context parameters.</para>
        /// </summary>
        [NameInMap("ContextParams")]
        [Validation(Required=false)]
        public Dictionary<string, object> ContextParams { get; set; }

        /// <summary>
        /// <para>The exposure list.</para>
        /// </summary>
        [NameInMap("ExposureList")]
        [Validation(Required=false)]
        public List<string> ExposureList { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>learn-pairec-xxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The recall management service version ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("RecallManagementServiceVersionId")]
        [Validation(Required=false)]
        public string RecallManagementServiceVersionId { get; set; }

        /// <summary>
        /// <para>The recall data details.</para>
        /// </summary>
        [NameInMap("Recalls")]
        [Validation(Required=false)]
        public Dictionary<string, object> Recalls { get; set; }

        /// <summary>
        /// <para>The retained fields.</para>
        /// </summary>
        [NameInMap("RetainFields")]
        [Validation(Required=false)]
        public List<string> RetainFields { get; set; }

        /// <summary>
        /// <para>The user ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1001</para>
        /// </summary>
        [NameInMap("Uid")]
        [Validation(Required=false)]
        public string Uid { get; set; }

    }

}

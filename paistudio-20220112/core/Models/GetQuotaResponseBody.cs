// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class GetQuotaResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ByNodeSpec</para>
        /// </summary>
        [NameInMap("AllocateStrategy")]
        [Validation(Required=false)]
        public string AllocateStrategy { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>18846926616</para>
        /// </summary>
        [NameInMap("CreatorId")]
        [Validation(Required=false)]
        public string CreatorId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>this is a test quota</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2023-06-22T00:00:00Z</para>
        /// </summary>
        [NameInMap("GmtCreatedTime")]
        [Validation(Required=false)]
        public string GmtCreatedTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2023-06-22T00:00:00Z</para>
        /// </summary>
        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        [NameInMap("HyperZones")]
        [Validation(Required=false)]
        public List<string> HyperZones { get; set; }

        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<Label> Labels { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>operation1234</para>
        /// </summary>
        [NameInMap("LatestOperationId")]
        [Validation(Required=false)]
        public string LatestOperationId { get; set; }

        [NameInMap("Min")]
        [Validation(Required=false)]
        public ResourceSpec Min { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>quota1ci8g793pgm</para>
        /// </summary>
        [NameInMap("ParentQuotaId")]
        [Validation(Required=false)]
        public string ParentQuotaId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>PaiStrategyIntelligent</para>
        /// </summary>
        [NameInMap("QueueStrategy")]
        [Validation(Required=false)]
        public string QueueStrategy { get; set; }

        [NameInMap("QuotaConfig")]
        [Validation(Required=false)]
        public QuotaConfig QuotaConfig { get; set; }

        [NameInMap("QuotaDetails")]
        [Validation(Required=false)]
        public QuotaDetails QuotaDetails { get; set; }

        /// <summary>
        /// <para>Quota Id</para>
        /// 
        /// <b>Example:</b>
        /// <para>quotajradxh43rgb</para>
        /// </summary>
        [NameInMap("QuotaId")]
        [Validation(Required=false)]
        public string QuotaId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test-quota</para>
        /// </summary>
        [NameInMap("QuotaName")]
        [Validation(Required=false)]
        public string QuotaName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>“”</para>
        /// </summary>
        [NameInMap("ReasonCode")]
        [Validation(Required=false)]
        public string ReasonCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>“”</para>
        /// </summary>
        [NameInMap("ReasonMessage")]
        [Validation(Required=false)]
        public string ReasonMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>18D5A1C6-14B8-545E-8408-0A7DDB4C6B5E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResourceGroupIds")]
        [Validation(Required=false)]
        public List<string> ResourceGroupIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ECS</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Ready</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("SubQuotas")]
        [Validation(Required=false)]
        public List<QuotaIdName> SubQuotas { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1.0</para>
        /// </summary>
        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

        [NameInMap("Workspaces")]
        [Validation(Required=false)]
        public List<WorkspaceIdName> Workspaces { get; set; }

    }

}

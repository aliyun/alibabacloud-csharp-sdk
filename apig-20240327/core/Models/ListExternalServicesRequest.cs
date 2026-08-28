// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListExternalServicesRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to return only services that have not been imported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("importableOnly")]
        [Validation(Required=false)]
        public bool? ImportableOnly { get; set; }

        /// <summary>
        /// <para>The maximum number of results to return. Valid range: (0, 100]. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// <para>Fuzzy search by API name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>imah</para>
        /// </summary>
        [NameInMap("nameLike")]
        [Validation(Required=false)]
        public string NameLike { get; set; }

        /// <summary>
        /// <para>The workspace ID of the PAI-EAS service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>667435</para>
        /// </summary>
        [NameInMap("paiWorkspaceId")]
        [Validation(Required=false)]
        public string PaiWorkspaceId { get; set; }

        /// <summary>
        /// <para>The service source type used to query services. This parameter is essentially required. If not provided, the API returns 400 InvalidParameter.WithValue. Valid values: SAE_K8S_SERVICE, PAI_EAS_SERVICE, CloudFlow, K8S, FC3, PAI_WORKSPACE, and MSE_NACOS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FC3</para>
        /// </summary>
        [NameInMap("sourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

    }

}

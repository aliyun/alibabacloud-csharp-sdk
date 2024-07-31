// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Governance20210120.Models
{
    public class EnrollAccountRequest : TeaModel {
        /// <summary>
        /// The prefix for the account name of the member.
        /// 
        /// *   If the account baseline is applied to an account that is newly created, you must configure this parameter.
        /// *   If the account baseline is applied to an existing account, you do not need to configure this parameter.
        /// </summary>
        [NameInMap("AccountNamePrefix")]
        [Validation(Required=false)]
        public string AccountNamePrefix { get; set; }

        /// <summary>
        /// The account ID.
        /// 
        /// *   If the account baseline is applied to an account that is newly created, you do not need to configure this parameter.
        /// *   If the account baseline is applied to an existing account, you must configure this parameter.
        /// </summary>
        [NameInMap("AccountUid")]
        [Validation(Required=false)]
        public long? AccountUid { get; set; }

        /// <summary>
        /// The baseline ID.
        /// 
        /// If this parameter is left empty, the default baseline is used.
        /// </summary>
        [NameInMap("BaselineId")]
        [Validation(Required=false)]
        public string BaselineId { get; set; }

        /// <summary>
        /// An array that contains baseline items.
        /// 
        /// If this parameter is specified, the configurations of the baseline items are merged with the baseline of the specified account. The configurations of the same baseline items are subject to the configuration of this parameter. We recommend that you leave this parameter empty and configure the `BaselineId` parameter to specify an account baseline and apply the configuration of the account baseline to the account.
        /// </summary>
        [NameInMap("BaselineItems")]
        [Validation(Required=false)]
        public List<EnrollAccountRequestBaselineItems> BaselineItems { get; set; }
        public class EnrollAccountRequestBaselineItems : TeaModel {
            /// <summary>
            /// The configurations of the baseline item.
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            /// <summary>
            /// The name of the baseline item.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// Specifies whether to skip the baseline item. Valid values:
            /// 
            /// *   false: The baseline item is not skipped.
            /// *   true: The baseline item is skipped.
            /// </summary>
            [NameInMap("Skip")]
            [Validation(Required=false)]
            public bool? Skip { get; set; }

            /// <summary>
            /// The version of the baseline item.
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// The display name of the account.
        /// 
        /// *   If the account baseline is applied to an account that is newly created, you must configure this parameter.
        /// *   If the account baseline is applied to an existing account, you do not need to configure this parameter.
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// The ID of the parent folder.
        /// 
        /// *   If the account baseline is applied to an account that is newly created, you need to specify a parent folder. If you do not configure this parameter, the account is created in the Root folder.
        /// *   If the account baseline is applied to an existing account, you do not need to configure this parameter.
        /// </summary>
        [NameInMap("FolderId")]
        [Validation(Required=false)]
        public string FolderId { get; set; }

        /// <summary>
        /// The ID of the billing account.
        /// 
        /// *   If the account baseline is applied to an account that is newly created, you need to specify a billing account. If you do not configure this parameter, the self-pay settlement method is used for the account.
        /// *   If the account baseline is applied to an existing account, you do not need to configure this parameter.
        /// </summary>
        [NameInMap("PayerAccountUid")]
        [Validation(Required=false)]
        public long? PayerAccountUid { get; set; }

        /// <summary>
        /// The region ID.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The identity type of the member. Valid values:
        /// 
        /// *   resell (default): The member is an account for a reseller. A relationship is automatically established between the member and the reseller. The management account of the resource directory must be used as the billing account of the member.
        /// *   non_resell: The member is not an account for a reseller. The member is an account that is not associated with a reseller. You can directly use the account to purchase Alibaba Cloud resources. The member is used as its own billing account.
        /// 
        /// > This parameter is available only for resellers at the international site (alibabacloud.com).
        /// </summary>
        [NameInMap("ResellAccountType")]
        [Validation(Required=false)]
        public string ResellAccountType { get; set; }

    }

}

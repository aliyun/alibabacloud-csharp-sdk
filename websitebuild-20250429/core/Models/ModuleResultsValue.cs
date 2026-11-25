// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class ModuleResultsValue : TeaModel {
        /// <summary>
        /// <para>Returned only for APP_WORKSPACE. This parameter indicates the target total quantity for this check, which is the used quantity in the saved configuration plus the ResourceValue. If a compatible DesiredTotal is provided, this total quantity is used directly. The used quantity for issues is the sum of normal and word-of-mouth issues in the saved configuration, and the used quantity for competitors is the number of competitors. This parameter is empty for APP and USER checks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21</para>
        /// </summary>
        [NameInMap("DesiredTotal")]
        [Validation(Required=false)]
        public long? DesiredTotal { get; set; }

        /// <summary>
        /// <para>The error code when the check fails. This parameter is null when the check passes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Resource.Control.No.Usage</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message when the check fails. This parameter is null when the check passes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Quota exhausted</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>Returned only for APP_WORKSPACE quantity pre-checks. This parameter indicates the maximum number of issues or competitors allowed by the current commodity version, not the remaining quota. This parameter is empty for APP and USER checks or when the version benefits cannot be determined.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("Limit")]
        [Validation(Required=false)]
        public long? Limit { get; set; }

        /// <summary>
        /// <para>Indicates whether the check passed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Passed")]
        [Validation(Required=false)]
        public bool? Passed { get; set; }

        /// <summary>
        /// <para>The resource identifier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InspirationTokens</para>
        /// </summary>
        [NameInMap("ResourceCode")]
        [Validation(Required=false)]
        public string ResourceCode { get; set; }

        /// <summary>
        /// <para>Indicates whether a purchasable higher version exists that can accommodate the DesiredTotal. This parameter is true only when the capacity of the current version is insufficient and a higher version meets the requirements. Otherwise, this parameter is false. This parameter may be empty for APP and USER checks. This field does not indicate that an upgrade has been performed or an upgrade order has been created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("UpgradeAvailable")]
        [Validation(Required=false)]
        public bool? UpgradeAvailable { get; set; }

    }

}

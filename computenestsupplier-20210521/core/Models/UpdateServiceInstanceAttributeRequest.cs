// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class UpdateServiceInstanceAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The time when the service instance expires.</para>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-12-25T02:28:40Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The License Data</para>
        /// </summary>
        [NameInMap("LicenseData")]
        [Validation(Required=false)]
        public UpdateServiceInstanceAttributeRequestLicenseData LicenseData { get; set; }
        public class UpdateServiceInstanceAttributeRequestLicenseData : TeaModel {
            /// <summary>
            /// <para>The Custom Data</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;Test&quot;}</para>
            /// </summary>
            [NameInMap("CustomData")]
            [Validation(Required=false)]
            public string CustomData { get; set; }

            /// <summary>
            /// <para>Mock response info.</para>
            /// </summary>
            [NameInMap("ResponseInfo")]
            [Validation(Required=false)]
            public UpdateServiceInstanceAttributeRequestLicenseDataResponseInfo ResponseInfo { get; set; }
            public class UpdateServiceInstanceAttributeRequestLicenseDataResponseInfo : TeaModel {
                /// <summary>
                /// <para>Mock error code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>EntityNotExist.Service</para>
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// <para>Mock error message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The provided parameter &quot;ServiceId&quot; is invalid.</para>
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// <para>if you want mock response, please open this option.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("UpdateResponse")]
                [Validation(Required=false)]
                public bool? UpdateResponse { get; set; }

            }

        }

        /// <summary>
        /// <para>Application reason, currently used for trial application extension.</para>
        /// 
        /// <b>Example:</b>
        /// <para>\&quot;\&quot;</para>
        /// </summary>
        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The service instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>si-3df88e962cdexxxxxxxx</para>
        /// </summary>
        [NameInMap("ServiceInstanceId")]
        [Validation(Required=false)]
        public string ServiceInstanceId { get; set; }

    }

}

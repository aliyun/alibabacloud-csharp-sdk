// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class UpdateServiceResponseBody : TeaModel {
        [NameInMap("DryRunResult")]
        [Validation(Required=false)]
        public UpdateServiceResponseBodyDryRunResult DryRunResult { get; set; }
        public class UpdateServiceResponseBodyDryRunResult : TeaModel {
            [NameInMap("RolePolicy")]
            [Validation(Required=false)]
            public UpdateServiceResponseBodyDryRunResultRolePolicy RolePolicy { get; set; }
            public class UpdateServiceResponseBodyDryRunResultRolePolicy : TeaModel {
                [NameInMap("MissingPolicy")]
                [Validation(Required=false)]
                public List<UpdateServiceResponseBodyDryRunResultRolePolicyMissingPolicy> MissingPolicy { get; set; }
                public class UpdateServiceResponseBodyDryRunResultRolePolicyMissingPolicy : TeaModel {
                    [NameInMap("Action")]
                    [Validation(Required=false)]
                    public List<string> Action { get; set; }

                    [NameInMap("Resource")]
                    [Validation(Required=false)]
                    public string Resource { get; set; }

                    [NameInMap("ServiceName")]
                    [Validation(Required=false)]
                    public string ServiceName { get; set; }

                }

                [NameInMap("Policy")]
                [Validation(Required=false)]
                public string Policy { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DF0F666F-FBBC-55C3-A368-C955DE7B4839</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

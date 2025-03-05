// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class UpdateServiceTestCaseRequest : TeaModel {
        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The service test case id.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>stc-2deec15c20b24aaf9f16</para>
        /// </summary>
        [NameInMap("TestCaseId")]
        [Validation(Required=false)]
        public string TestCaseId { get; set; }

        /// <summary>
        /// <para>The service test case name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>case1</para>
        /// </summary>
        [NameInMap("TestCaseName")]
        [Validation(Required=false)]
        public string TestCaseName { get; set; }

        /// <summary>
        /// <para>The service test config.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// <para>parameters:
        ///   PayType: &quot;PostPaid&quot;
        ///   EcsInstanceType: &quot;$[iact3-auto]&quot;
        ///   InstancePassword: &quot;$[iact3-auto]&quot;</para>
        /// </summary>
        [NameInMap("TestConfig")]
        [Validation(Required=false)]
        public string TestConfig { get; set; }

    }

}

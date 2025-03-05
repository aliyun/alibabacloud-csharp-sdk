// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class CreateServiceTestCaseResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E50287CB-AABF-4877-92C0-289B339A1546</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The test case Id</para>
        /// 
        /// <b>Example:</b>
        /// <para>stc-5ba03a6a9a2746be8739</para>
        /// </summary>
        [NameInMap("TestCaseId")]
        [Validation(Required=false)]
        public string TestCaseId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeFrontVulPatchListResponseBody : TeaModel {
        /// <summary>
        /// <para>An array consisting of the information about the pre-patches that are required to fix the specified Windows system vulnerability.</para>
        /// </summary>
        [NameInMap("FrontPatchList")]
        [Validation(Required=false)]
        public List<DescribeFrontVulPatchListResponseBodyFrontPatchList> FrontPatchList { get; set; }
        public class DescribeFrontVulPatchListResponseBodyFrontPatchList : TeaModel {
            /// <summary>
            /// <para>An array consisting of the pre-patches that are required to fix the specified Windows system vulnerability on the server.</para>
            /// </summary>
            [NameInMap("PatchList")]
            [Validation(Required=false)]
            public List<DescribeFrontVulPatchListResponseBodyFrontPatchListPatchList> PatchList { get; set; }
            public class DescribeFrontVulPatchListResponseBodyFrontPatchListPatchList : TeaModel {
                /// <summary>
                /// <para>The name of the vulnerability.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RHBA-2019:2599: krb5 bug fix update</para>
                /// </summary>
                [NameInMap("AliasName")]
                [Validation(Required=false)]
                public string AliasName { get; set; }

                /// <summary>
                /// <para>The version number of the pre-patch that is required to fix the Windows system vulnerability.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4523204</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The UUID of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1587bedb-fdb4-48c4-9330-4545****</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F929E952-EBFC-56C3-BD35-BF8B59024C68</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

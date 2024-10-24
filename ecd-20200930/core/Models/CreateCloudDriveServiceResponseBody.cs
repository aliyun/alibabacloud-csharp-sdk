// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class CreateCloudDriveServiceResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the attached cloud disk.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou+cds-7782057786</para>
        /// </summary>
        [NameInMap("CdsId")]
        [Validation(Required=false)]
        public string CdsId { get; set; }

        /// <summary>
        /// <para>The name of the cloud disk that is created in Cloud Drive Service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CDS_Windows_1126</para>
        /// </summary>
        [NameInMap("CdsName")]
        [Validation(Required=false)]
        public string CdsName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cen-638u3wxds9snyc****</para>
        /// </summary>
        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        [NameInMap("ConflictCdsAndOrder")]
        [Validation(Required=false)]
        public CreateCloudDriveServiceResponseBodyConflictCdsAndOrder ConflictCdsAndOrder { get; set; }
        public class CreateCloudDriveServiceResponseBodyConflictCdsAndOrder : TeaModel {
            [NameInMap("ConflictCds")]
            [Validation(Required=false)]
            public List<CreateCloudDriveServiceResponseBodyConflictCdsAndOrderConflictCds> ConflictCds { get; set; }
            public class CreateCloudDriveServiceResponseBodyConflictCdsAndOrderConflictCds : TeaModel {
                [NameInMap("CdsId")]
                [Validation(Required=false)]
                public string CdsId { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

            }

            [NameInMap("ConflictOrder")]
            [Validation(Required=false)]
            public List<CreateCloudDriveServiceResponseBodyConflictCdsAndOrderConflictOrder> ConflictOrder { get; set; }
            public class CreateCloudDriveServiceResponseBodyConflictCdsAndOrderConflictOrder : TeaModel {
                [NameInMap("CdsId")]
                [Validation(Required=false)]
                public string CdsId { get; set; }

                [NameInMap("OrderId")]
                [Validation(Required=false)]
                public string OrderId { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test1.local</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The maximum capacity of each instance in Cloud Drive Service. Unit: GiB</para>
        /// 
        /// <b>Example:</b>
        /// <para>213674622976</para>
        /// </summary>
        [NameInMap("MaxSize")]
        [Validation(Required=false)]
        public string MaxSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AD_CONNECTOR</para>
        /// </summary>
        [NameInMap("OfficeSiteType")]
        [Validation(Required=false)]
        public string OfficeSiteType { get; set; }

        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>062B1439-709A-580E-85DF-CE97A1560565</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

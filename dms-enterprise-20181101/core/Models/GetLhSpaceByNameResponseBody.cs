// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetLhSpaceByNameResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code returned if the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The workspace for data warehouse development.</para>
        /// </summary>
        [NameInMap("LakehouseSpace")]
        [Validation(Required=false)]
        public GetLhSpaceByNameResponseBodyLakehouseSpace LakehouseSpace { get; set; }
        public class GetLhSpaceByNameResponseBodyLakehouseSpace : TeaModel {
            /// <summary>
            /// <para>The ID of the user who creates the workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>51***</para>
            /// </summary>
            [NameInMap("CreatorId")]
            [Validation(Required=false)]
            public string CreatorId { get; set; }

            /// <summary>
            /// <para>The description of the workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The ID of the development database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2435****</para>
            /// </summary>
            [NameInMap("DevDbId")]
            [Validation(Required=false)]
            public int? DevDbId { get; set; }

            /// <summary>
            /// <para>The type of the database. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>14</b>: AnalyticDB for MySQL</description></item>
            /// <item><description><b>18</b>: AnalyticDB for PostgreSQL</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>14</para>
            /// </summary>
            [NameInMap("DwDbType")]
            [Validation(Required=false)]
            public string DwDbType { get; set; }

            /// <summary>
            /// <para>The ID of the workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>Indicates whether the workspace is deleted. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: The workspace is deleted.</description></item>
            /// <item><description><b>false</b>: The workspace is not deleted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsDeleted")]
            [Validation(Required=false)]
            public bool? IsDeleted { get; set; }

            /// <summary>
            /// <para>The mode in which the workspace runs. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: basic mode</description></item>
            /// <item><description><b>1</b>: standard mode</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public int? Mode { get; set; }

            /// <summary>
            /// <para>The ID of the production database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2442****</para>
            /// </summary>
            [NameInMap("ProdDbId")]
            [Validation(Required=false)]
            public int? ProdDbId { get; set; }

            /// <summary>
            /// <para>The configuration of the workspace. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>skipManualRunCheck</b>: No security rule check is required in the trial run phase.</description></item>
            /// <item><description><b>skipPublishApprove</b>: No approval is required for publishing and O\&amp;M.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;skipManualRunCheck\&quot;:true,\&quot;skipPublishApprove\&quot;:true}</para>
            /// </summary>
            [NameInMap("SpaceConfig")]
            [Validation(Required=false)]
            public string SpaceConfig { get; set; }

            /// <summary>
            /// <para>The name of the workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_space</para>
            /// </summary>
            [NameInMap("SpaceName")]
            [Validation(Required=false)]
            public string SpaceName { get; set; }

            /// <summary>
            /// <para>The ID of the tenant to which the workspace belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3***</para>
            /// </summary>
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FE8CA4A8-AB2D-55B7-BD30-01A4609F40D8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request is successful.</description></item>
        /// <item><description><b>false</b>: The request fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

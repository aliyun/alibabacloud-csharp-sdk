// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypnsapi20170525.Models
{
    public class QueryGateVerifyStatisticPublicRequest : TeaModel {
        /// <summary>
        /// <para>The verification method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: one-click logon</description></item>
        /// <item><description><b>2</b>: phone number verification, including the verification of the phone number used in HTML5 pages</description></item>
        /// <item><description><b>3</b>: SMS verification</description></item>
        /// <item><description><b>4</b>: facial recognition</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AuthenticationType")]
        [Validation(Required=false)]
        public int? AuthenticationType { get; set; }

        /// <summary>
        /// <para>The end date. Specify this parameter in the YYYYMMDD format. Example: 20220106.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20220106</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// <para>The type of the operating system. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Android</b></description></item>
        /// <item><description><b>iOS</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Android</para>
        /// </summary>
        [NameInMap("OsType")]
        [Validation(Required=false)]
        public string OsType { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        /// <summary>
        /// <para>The service code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FC100000038194004</para>
        /// </summary>
        [NameInMap("SceneCode")]
        [Validation(Required=false)]
        public string SceneCode { get; set; }

        /// <summary>
        /// <para>The start date. Specify this parameter in the YYYYMMDD format. Example: 20220101.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20220101</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

    }

}

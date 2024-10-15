// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class AddVirtualNumberRelationRequest : TeaModel {
        /// <summary>
        /// <para>The company names. Separate multiple company names with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>Company 1</para>
        /// </summary>
        [NameInMap("CorpNameList")]
        [Validation(Required=false)]
        public string CorpNameList { get; set; }

        /// <summary>
        /// <para>The real numbers. Separate multiple real numbers with commas (,).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1321111****,1322222****</para>
        /// </summary>
        [NameInMap("NumberList")]
        [Validation(Required=false)]
        public string NumberList { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The virtual number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>05516214****</para>
        /// </summary>
        [NameInMap("PhoneNum")]
        [Validation(Required=false)]
        public string PhoneNum { get; set; }

        /// <summary>
        /// <para>The service name. Default value: <b>dyvms</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dyvms</para>
        /// </summary>
        [NameInMap("ProdCode")]
        [Validation(Required=false)]
        public string ProdCode { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The route type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: number location first.</description></item>
        /// <item><description><b>1</b>: random.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RouteType")]
        [Validation(Required=false)]
        public int? RouteType { get; set; }

    }

}

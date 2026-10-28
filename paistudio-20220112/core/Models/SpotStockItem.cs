// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class SpotStockItem : TeaModel {
        /// <summary>
        /// <para>The instance type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ml.gp7vf.16.40xlarge</para>
        /// </summary>
        [NameInMap("instanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The inventory details.</para>
        /// </summary>
        [NameInMap("internalInfo")]
        [Validation(Required=false)]
        public List<SpotStockInternalInfo> InternalInfo { get; set; }

        /// <summary>
        /// <para>The inventory status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>High</para>
        /// </summary>
        [NameInMap("stockStatus")]
        [Validation(Required=false)]
        public string StockStatus { get; set; }

    }

}

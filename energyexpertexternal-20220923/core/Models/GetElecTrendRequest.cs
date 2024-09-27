// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class GetElecTrendRequest : TeaModel {
        /// <summary>
        /// <para>The enterprise code.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C-20240115-3</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>List of years.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("yearList")]
        [Validation(Required=false)]
        public List<int?> YearList { get; set; }

    }

}

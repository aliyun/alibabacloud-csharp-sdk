// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class ChangeApplyShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The list of passengers for the change.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("change_passenger_list")]
        [Validation(Required=false)]
        public string ChangePassengerListShrink { get; set; }

        /// <summary>
        /// <para>The target journey for the change.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("changed_journeys")]
        [Validation(Required=false)]
        public string ChangedJourneysShrink { get; set; }

        /// <summary>
        /// <para>The contact information for the change.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("contact")]
        [Validation(Required=false)]
        public string ContactShrink { get; set; }

        /// <summary>
        /// <para>The order number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4988430***950</para>
        /// </summary>
        [NameInMap("order_num")]
        [Validation(Required=false)]
        public long? OrderNum { get; set; }

        /// <summary>
        /// <para>The buyer remarks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>remark desc</para>
        /// </summary>
        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The change type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: voluntary change</description></item>
        /// <item><description>1: flight schedule change or flight cancellation.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

    }

}
